using RegisterVehicle.Entities;
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

        VehicleService vehicleService = new VehicleService();
        public EditForm() {
            InitializeComponent();
        }

        public void loadById(int id) {
         Vehicle vehicle = vehicleService.LoadById(id);
        
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }
    }
}
