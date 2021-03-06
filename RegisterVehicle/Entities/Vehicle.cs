﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using RegisterVehicle.Entities.Enums;

namespace RegisterVehicle.Entities {

    [Table("vehicle")]
    public class Vehicle {


        public int id { get; set; }
        public string model { get; set; }
        public string brand { get; set; }
        public string year { get; set; }
        public EnumType? type { get; set; }
        public Cor cor { get; set; }
        //public Pessoa pessoa { get; set; }

    }
}
