using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RegisterVehicle.Entities {

    [Table("cor")]
    public class Cor {

        public int id { get; set; }
        public string cor { get; set; }
        public override string ToString() {
            return cor;
        }
        public override bool Equals(object obj) {
            switch (obj) {
                case Cor c:
                    return id == c.id;
                default: return false;
            }
        }
    }


}
