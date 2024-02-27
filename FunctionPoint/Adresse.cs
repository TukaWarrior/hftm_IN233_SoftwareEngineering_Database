using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPoint
{
    internal class Adresse
    {
        public int AdresseID { get; set; }
        public int PersonID { get; set; }
        public string Strasse { get; set; }
        public string Nummer { get; set; }
        public DateTime GueltigAb { get; set; }
        public DateTime GueltigBis { get; set; }
        public int PLZ { get; set; }
    }
}
