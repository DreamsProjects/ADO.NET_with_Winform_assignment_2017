using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UppgraderingAdressBok.DataContext
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public int Kontakt { get; set; }

        public virtual ICollection<Adress> Adresser { get; set; }
        public virtual ICollection<Epost> Epostadresser { get; set; }
        public virtual ICollection<Telefon> Telefonnummer { get; set; }
        public virtual Kontakt Kontakttyp { get; set; }
    }
}
