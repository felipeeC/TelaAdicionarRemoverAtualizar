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

        //cria uma instancia da classe vehicleService para poder chamar os métodos que estão na classe Vehicle service
        

        //inicializa a forma mainform
        public MainForm() {
            InitializeComponent();
            PopulaListView();
        }

        //passa veiculo para a classe editForm para ter somente 1 acesso ao banco, não causa conflito de dados


        //Evento de botão add vehicle
        private void buttonAdd_Click(object sender, EventArgs e) {
            EditForm telanova = new EditForm();
            telanova.InitializeForm();
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

        //metodo utilizado anteriormente para pegar as informações do listView e passar para as textboxes, pode ser utilizado caso esteja na mesma mainframe
        //private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        //    if (listView1.SelectedItems.Count == 1) {

        //        ListViewItem listViewItem = listView1.SelectedItems[0];
        //        txtId.Text = listViewItem.SubItems[3].Text;
        //        txtModel.Text = listViewItem.SubItems[0].Text;
        //        txtBrand.Text = listViewItem.SubItems[1].Text;
        //        txtYear.Text = listViewItem.SubItems[2].Text;
        //        if (!string.IsNullOrEmpty(listViewItem.SubItems[4].Text)) {
        //            comboCarType.SelectedItem = Enum.Parse(typeof(EnumType), listViewItem.SubItems[4].Text);
        //        }
        //        if (!string.IsNullOrEmpty(listViewItem.SubItems[5].Text)) {
        //            comboCor.SelectedItem = (listViewItem.SubItems[5].Text);
        //        }
        //    }
        //}

        private void PopulaListView() {
            using VehicleService vehicleService = new VehicleService();
            //limpa os itens da listview antes de adicionar novamente, para não ocasionar congelamento de dados
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

            }
        }

        //Botão para remover, passa o ID para entity framework fazer a remoção no banco
        private void buttonRemove_Click(object sender, EventArgs e) {
            using VehicleService vehicleService = new VehicleService();

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

        //Evento para editar, pesquisa no banco pelo id e preenche os campos da tela editForm
        private void button2_Click(object sender, EventArgs e) {
            
            int id = ReturnIdItemSelected();

            EditForm telanova = new EditForm();
            telanova.InitializeForm();
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

        
        //Botão reaload da list view
        private void button3_Click(object sender, EventArgs e) {
            PopulaListView();
        }

        //====================================================================================

        //Eventos não utilizados


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
