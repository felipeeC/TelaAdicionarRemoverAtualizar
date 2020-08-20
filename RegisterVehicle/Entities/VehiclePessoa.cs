using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RegisterVehicle.Entities
{
    [Table("vehicle_pessoa")]
    public class VehiclePessoa
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("vehicleid")]
        public int VehicleId { get; set; }
        [Column("pessoaid")]
        public int PessoaId { get; set; }

        public Vehicle vehicle { get; set; }
        public Pessoa pessoa { get; set; }
    }
}
