using System.ComponentModel.DataAnnotations;
using System;

namespace UppgraderingAdressBok.DataContext
{
    public class Epost
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(150)]
        public string Epostaddress { get; set; }

        public virtual Person PersonID { get; set; }

    }
}
