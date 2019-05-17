using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UppgraderingAdressBok.DataContext
{
   public class Telefon
    {
        [Key]
        public int ID { get; set; }
        public int Riktnummer { get; set; }
        public string Telefonnummer { get; set; }

        public virtual Person PersonID { get; set; }
    }
}
