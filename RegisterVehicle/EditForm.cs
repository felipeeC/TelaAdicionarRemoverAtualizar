﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RegisterVehicle.Entities;
using RegisterVehicle.Entities.Enums;
using RegisterVehicle.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegisterVehicle {
    public partial class EditForm : Form {
        
        VehicleService vehicleService;
        
        private bool podeIniciar;

        public EditForm() {

            InitializeComponent();            
        }
        //recebe o veiculo da classe mainform e inicializa o form
        public void InitializeForm(VehicleService vehicle) {
            vehicleService = vehicle;
            cbCarType.Items.Clear();
            cbCarType.Items.Add(EnumType.Car);
            cbCarType.Items.Add(EnumType.Coupe);
            cbCarType.Items.Add(EnumType.Pickup);
            foreach (var cor in vehicleService.CarregaComboBoxCor()) {
                cbCor.Items.Add(cor);
            }
        }
        //Método para carregar os dados do banco por ID
        public bool loadById(int id) {
            
            Vehicle vehicle = vehicleService.LoadById(id);
            if (vehicle == null) {

                return false;
            }
            else {
                textId.Text = id.ToString();
                textModel.Text = vehicle.model;
                textYear.Text = vehicle.year;
                textBrand.Text = vehicle.brand;
                cbCarType.SelectedItem = vehicle.type;
                cbCor.SelectedItem = vehicle.cor;
                return true;
            }
        }

        //Botão Save
        private void button1_Click(object sender, EventArgs e) {
            
            if (string.IsNullOrEmpty(textModel.Text)) {

                MessageBox.Show("Nenhum valor preenchido");
            }
            if (!string.IsNullOrEmpty(textId.Text)) {

                vehicleService.EditVehicle(textId.Text, textModel.Text, textBrand.Text, textYear.Text, (EnumType?)cbCarType.SelectedItem, (Cor)cbCor.SelectedItem);
                Close();
            }
            else {
                vehicleService.NewVehicle(textModel.Text, textBrand.Text, textYear.Text, (EnumType?)cbCarType.SelectedItem, (Cor)cbCor.SelectedItem);
                textModel.Text = "";
                textBrand.Text = "";
                textYear.Text = "";
                Close();
            }
        }



    
        



















        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }

        private void buttonAdd_Click(object sender, EventArgs e) {


        }
        public void RecebeSelectedItems() {


        }


    }



}