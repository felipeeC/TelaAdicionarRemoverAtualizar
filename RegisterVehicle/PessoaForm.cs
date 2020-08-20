using RegisterVehicle.Entities;
using RegisterVehicle.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegisterVehicle
{
    public partial class PessoaForm : Form
    {
        public PessoaForm()
        {
            InitializeComponent();
        }
        public void InitializeForm()
        {
            using VehicleService vehicleService = new VehicleService();
            PopulaListViewPessoa();


        }

        /// <summary>
        /// Método para preencher a lista de pessoas
        /// </summary>
        private void PopulaListViewPessoa()
        {
            using VehicleService vehicleService = new VehicleService();
            //limpa os itens da listview antes de adicionar novamente, para não ocasionar congelamento de dados
            listVPessoa.Items.Clear();
            //utilizando a instancia vehicleService para chamar o metodo listVehicle
            List<Pessoa> listaRecebida = vehicleService.ListTodasPessoas();
            foreach (Pessoa pessoas in listaRecebida)
            {
                ListViewItem listViewItem = listVPessoa.Items.Add(pessoas.id.ToString());
                listViewItem.SubItems.Add(pessoas.nome);
            }
        }

        public int ReturnIdPessoaSelected()
        {
            int id = 0;
            if (listVPessoa.SelectedItems.Count == 1)
            {
                ListViewItem listViewItem = listVPessoa.SelectedItems[0];
                id = int.Parse(listViewItem.SubItems[0].Text);
            }
            return id;
        }

    //    List<Pessoa> pessoaRecebida = vehicleService.ListPessoas(vehicle.id).ToList();
    //            foreach(var pessoaLista in pessoaRecebida)
    //            {
    //                ListViewItem listViewItem = listViewPessoa.Items.Add(pessoaLista.nome);
    //}


    public void PreencheVehicleList()
        {
            int pessoaId;
            pessoaId = ReturnIdPessoaSelected();
            using VehicleService vehicleService = new VehicleService();
           // Vehicle vehicle = vehicleService.ListVehiclePorPessoa(pessoaId).ToList();




            List<Vehicle> vehicleRecebido = vehicleService.ListVehiclePorPessoa(pessoaId).ToList();
            foreach (var vehicleLista in vehicleRecebido)
            {
                ListViewItem listViewItem = listVcarros.Items.Add(vehicleLista.model);
                listViewItem.SubItems.Add(vehicleLista.model);
            }

        }

        public int ReturnIdItemSelected()
        {
            int id = 0;
            if (listVPessoa.SelectedItems.Count == 1)
            {
                ListViewItem listViewItem = listVPessoa.SelectedItems[0];
                id = int.Parse(listViewItem.SubItems[0].Text);
            }
            return id;
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listVcarros.Items.Clear();
            PreencheVehicleList();
        }
    }
}
