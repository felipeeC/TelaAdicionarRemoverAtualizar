using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RegisterVehicle.Entities;
using RegisterVehicle.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegisterVehicle.Services {
    class VehicleService {

        MyDBContext MyDb = new MyDBContext();

        public void NewVehicle(string model, string brand, string year, EnumType? type, Cor? cor) {
            Vehicle vehicle = new Vehicle();
            vehicle.model = model;
            vehicle.brand = brand;
            vehicle.year = year;
            vehicle.type = type;
            vehicle.cor = cor;
            MyDb.Vehicle.Add(vehicle);
            //Roda o SQL no banco
            MyDb.SaveChanges();


            ///inicia uma transação roda o sql commita e faz rollback em caso de erro
            //try {
            //    MyDb.Database.BeginTransaction();
            //    
            //    MyDb.SaveChanges();
            //    MyDb.Database.CommitTransaction();
            //}
            //catch (Exception) {

            //    MyDb.Database.RollbackTransaction(); ;
            //}

        }
        public List<Cor> CarregaComboBoxCor() {
            List<Cor> returnColor = MyDb.cor.ToList();
            return returnColor;
        }

        public void EditVehicle(string idTx, string model, string brand, string year, EnumType? type, Cor? cor) {

            if (string.IsNullOrEmpty(idTx)) {

                return;
            }

            int id = int.Parse(idTx);

            Vehicle veiculoRetornado = MyDb.Vehicle.FirstOrDefault(f => f.id == id);

            if (veiculoRetornado != null) {

                veiculoRetornado.model = model;
                veiculoRetornado.brand = brand;
                veiculoRetornado.year = year;
                veiculoRetornado.type = type;
                veiculoRetornado.cor = cor;
                //veiculoRetornado.type = type;
                //Roda o SQL no banco
                MyDb.SaveChanges();
            }
        }
        public List<Vehicle> ListVehicle() {
            List<Vehicle> vehicleList = MyDb.Vehicle.ToList();
            return vehicleList;
        }

        public void DeleteVehicle(int id) {
            Vehicle veiculoRetornado = MyDb.Vehicle.First(f => f.id == id);

            MyDb.Vehicle.Remove(veiculoRetornado);
            MyDb.SaveChanges();
        }
    }
}



