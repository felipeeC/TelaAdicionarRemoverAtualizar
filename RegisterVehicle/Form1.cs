﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegisterVehicle;
using RegisterVehicle.Entities;
using RegisterVehicle.Entities.Enums;
using RegisterVehicle.Services;

namespace RegisterVehicle {
    public partial class Form1 : Form {




        public Form1() {
            InitializeComponent();
            
            //limpa combo e insere os do tipo enum
            comboCarType.Items.Clear();
            comboCarType.Items.Add(EnumType.Car);
            comboCarType.Items.Add(EnumType.Coupe);
            comboCarType.Items.Add(EnumType.Pickup);

            PopulaListView();

        }

        //cria uma instancia da classe vehicleService para poder chamar os métodos que estão na classe Vehicle service
        VehicleService vehicleService = new VehicleService();




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtModel.Text)) {
                MessageBox.Show("Nenhum valor preenchido");
            }
            else {
                vehicleService.NewVehicle(txtModel.Text, txtBrand.Text, txtYear.Text,(EnumType?)comboCarType.SelectedItem);
                txtModel.Text = "";
                txtBrand.Text = "";
                txtYear.Text = "";
                PopulaListView();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

            if (listView1.SelectedItems.Count == 1 ) {

                ListViewItem listViewItem = listView1.SelectedItems[0];
                txtId.Text = listViewItem.SubItems[3].Text;
                txtModel.Text = listViewItem.SubItems[0].Text;
                txtBrand.Text = listViewItem.SubItems[1].Text;
                txtYear.Text = listViewItem.SubItems[2].Text;
                if( !string.IsNullOrEmpty(listViewItem.SubItems[4].Text)) { 
                comboCarType.SelectedItem = Enum.Parse(typeof(EnumType), listViewItem.SubItems[4].Text);
                }
            }
        }

        private void PopulaListView() {

            listView1.Items.Clear();
            //utilizando a instancia vehicleService para chamar o metodo listVehicle
            List<Vehicle> listaRecebida = vehicleService.ListVehicle();
            foreach (Vehicle vehicle in listaRecebida) {
                ListViewItem listViewItem = listView1.Items.Add(vehicle.model);

                listViewItem.SubItems.Add(vehicle.brand);
                listViewItem.SubItems.Add(vehicle.year);
                listViewItem.SubItems.Add(vehicle.id.ToString());
                listViewItem.SubItems.Add(vehicle.type.ToString());
            }
        }



        private void Form1_Load(object sender, EventArgs e) {

        }

        private void buttonRemove_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count == 0) {
                MessageBox.Show("Nenhum item selecionado");
            }
            else {
                foreach (ListViewItem listViewItem in listView1.SelectedItems) {
                    int id = int.Parse(listViewItem.SubItems[3].Text);
                    vehicleService.DeleteVehicle(id);
                }
                PopulaListView();
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

            vehicleService.EditVehicle(txtId.Text, txtModel.Text, txtBrand.Text, txtYear.Text, (EnumType?) comboCarType.SelectedItem);
            PopulaListView();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) {

        }
    }
}