using System;
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
    public partial class MainForm : Form {




        public MainForm() {
            InitializeComponent();

            //limpa combo e insere os do tipo enum
            comboCarType.Items.Clear();
            comboCarType.Items.Add(EnumType.Car);
            comboCarType.Items.Add(EnumType.Coupe);
            comboCarType.Items.Add(EnumType.Pickup);
            foreach (var cor in vehicleService.CarregaComboBoxCor()) {
                comboCor.Items.Add(cor);

            }
            PopulaListView();
        }

        //cria uma instancia da classe vehicleService para poder chamar os métodos que estão na classe Vehicle service
        VehicleService vehicleService = new VehicleService();

        
        
        //passa veiculo para a classe editForm
        private VehicleService PassaVehicle() {
            VehicleService veiculo = vehicleService;
            return veiculo;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            EditForm telanova = new EditForm();
            telanova.ShowDialog();
            PopulaListView();
            //if (string.IsNullOrEmpty(txtModel.Text)) {
            //    MessageBox.Show("Nenhum valor preenchido");
            //}
            //else {
            //    vehicleService.NewVehicle(txtModel.Text, txtBrand.Text, txtYear.Text, (EnumType?)comboCarType.SelectedItem, (Cor?)comboCor.SelectedItem);
            //    txtModel.Text = "";
            //    txtBrand.Text = "";
            //    txtYear.Text = "";
            //    PopulaListView();
            //}
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

            if (listView1.SelectedItems.Count == 1) {

                ListViewItem listViewItem = listView1.SelectedItems[0];
                txtId.Text = listViewItem.SubItems[3].Text;
                txtModel.Text = listViewItem.SubItems[0].Text;
                txtBrand.Text = listViewItem.SubItems[1].Text;
                txtYear.Text = listViewItem.SubItems[2].Text;
                if (!string.IsNullOrEmpty(listViewItem.SubItems[4].Text)) {
                    comboCarType.SelectedItem = Enum.Parse(typeof(EnumType), listViewItem.SubItems[4].Text);
                }
                if (!string.IsNullOrEmpty(listViewItem.SubItems[5].Text)) {
                    comboCor.SelectedItem = (listViewItem.SubItems[5].Text);
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


                listViewItem.SubItems.Add(vehicle.cor?.ToString());
                txtModel.Text = "";
                txtBrand.Text = "";
                txtYear.Text = "";
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
            int id = ReturnIdItemSelected();

            EditForm telanova = new EditForm();
            telanova.InitializeForm(vehicleService);
            if (telanova.loadById(id)) {
                telanova.ShowDialog();
                PopulaListView();
            }
            else {
                MessageBox.Show("Nenhum item selecionado");
            }


        }
        public int ReturnIdItemSelected() {
            int id = 0;
            if (listView1.SelectedItems.Count == 1) {
                ListViewItem listViewItem = listView1.SelectedItems[0];
                id = int.Parse(listViewItem.SubItems[3].Text);
            }
            return id;

        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            PopulaListView();
        }
    }
}
