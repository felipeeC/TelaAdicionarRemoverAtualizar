using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RegisterVehicle.Entities;
using RegisterVehicle.Entities.Enums;
using RegisterVehicle.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegisterVehicle {
    public partial class EditForm : Form {



        private bool podeIniciar;

        public EditForm() {

            InitializeComponent();
        }
        //recebe o veiculo da classe mainform e inicializa o form
        public void InitializeForm() {
            using VehicleService vehicleService = new VehicleService();
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

            using VehicleService vehicleService = new VehicleService();
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
                List<Pessoa> pessoaRecebida =vehicleService.ListPessoas(vehicle.id).ToList();
                foreach(var pessoaLista in pessoaRecebida)
                {
                    ListViewItem listViewItem = listViewPessoa.Items.Add(pessoaLista.nome);
                }

                return true;
            }
        }


        //Botão hibrido, caso esteja vazio o ID, irá fazer um new vehicle, caso exista algum id, irá editar
        private void button1_Click(object sender, EventArgs e) {
            using VehicleService vehicleService = new VehicleService();
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }



}
