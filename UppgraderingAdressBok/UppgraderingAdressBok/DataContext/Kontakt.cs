using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UppgraderingAdressBok.DataContext
{
    public class Kontakt
    {
        [Key]
        public int ID { get; set; }
        public string Namn { get; set; }

        public virtual ICollection<Person> PersonID { get; set; }
    }
}
