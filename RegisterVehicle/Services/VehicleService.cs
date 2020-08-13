using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RegisterVehicle.Entities;
using RegisterVehicle.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegisterVehicle.Services
{
    public class VehicleService : IDisposable
    {

        MyDBContext MyDb = Db.Context;
        private bool disposedValue;




        /// <summary>
        /// Método para inserir um novo veículo no banco
        /// </summary>
        /// <param name="model"></param>
        /// <param name="brand"></param>
        /// <param name="year"></param>
        /// <param name="type"></param>
        /// <param name="cor"></param>
        public void NewVehicle(string model, string brand, string year, EnumType? type, Cor cor)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.model = model;
            vehicle.brand = brand;
            vehicle.year = year;
            vehicle.type = type;
            MyDb.Attach(cor);
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

        
        /// <summary>
        /// Método carrega Veículo via id no banco
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal Vehicle LoadById(int id)
        {
            Vehicle veiculoRetornado = MyDb.Vehicle.FirstOrDefault(f => f.id == id);
            return veiculoRetornado;
        }


        /// <summary>
        /// Método carrega combo box de Cor
        /// </summary>
        /// <returns></returns>
        public List<Cor> CarregaComboBoxCor()
        {
            List<Cor> returnColor = MyDb.cor.ToList();
            return returnColor;
        }







        /// <summary>
        /// Método Edita a o vehicle
        /// </summary>
        /// <param name="idTx"></param>
        /// <param name="model"></param>
        /// <param name="brand"></param>
        /// <param name="year"></param>
        /// <param name="type"></param>
        /// <param name="cor"></param>
        public void EditVehicle(string idTx, string model, string brand, string year, EnumType? type, Cor cor)
        {

            if (string.IsNullOrEmpty(idTx))
            {

                return;
            }
            int id = int.Parse(idTx);

            Vehicle veiculoRetornado = LoadById(id);

            if (veiculoRetornado != null)
            {

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



        /// <summary>
        /// Método carrega lista de veículos
        /// </summary>
        /// <returns></returns>
        public List<Vehicle> ListVehicle()
        {
            List<Vehicle> vehicleList = MyDb.Vehicle.ToList();
            return vehicleList;
        }




        /// <summary>
        /// Método deleta veículo
        /// </summary>
        /// <param name="id"></param>
        public void DeleteVehicle(int id)
        {
            Vehicle veiculoRetornado = LoadById(id);

            MyDb.Vehicle.Remove(veiculoRetornado);
            MyDb.SaveChanges();
        }














        /// <summary>
        /// Método que descarta da memória, libera os recursos.
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // MyDb.Dispose(); agora a conexão como banco é permanente, uma conexão para toda a aplicação

                }


                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}



