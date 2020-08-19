using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterVehicle.Entities
{
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public override string ToString()
        {
            return nome;
        }

    }
}
