using System.ComponentModel.DataAnnotations;

namespace UppgraderingAdressBok.DataContext
{
    public class Adress
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(150)]
        public string Gatunamn { get; set; }
        public string Postnummer { get; set; }
        [MaxLength(150)]
        public string Postort { get; set; }

        public virtual Person PersonID { get; set; }
    }
}
