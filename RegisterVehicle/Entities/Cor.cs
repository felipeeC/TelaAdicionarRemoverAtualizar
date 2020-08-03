using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RegisterVehicle.Entities {

    [Table("cor")]
    class Cor {

        public int id { get; set; }
        public string cor { get; set; }
        public override string ToString() {
            return cor;
        }
    }


}
