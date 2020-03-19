using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnageAPI.Models
{
    public class Personnage
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Classe { get; set; }
        public int PV { get; set; }
    }
}
