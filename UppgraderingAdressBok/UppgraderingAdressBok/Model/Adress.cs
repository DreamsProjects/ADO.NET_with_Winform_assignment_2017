using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgraderingAdressBok.Model
{
    public class Adress
    {
        public int ID { get; set; }
        public string Gatunamn { get; set; }
        public string Postnummer { get; set; }
        public string Postort { get; set; }
    }
}
