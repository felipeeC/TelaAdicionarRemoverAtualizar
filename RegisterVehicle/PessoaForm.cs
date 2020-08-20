using RegisterVehicle.Entities;
using RegisterVehicle.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
