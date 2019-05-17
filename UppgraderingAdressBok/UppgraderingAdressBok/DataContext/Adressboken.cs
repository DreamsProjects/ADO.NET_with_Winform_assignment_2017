namespace UppgraderingAdressBok.DataContext
{
    using System.Data.Entity;

    public class Adressboken : DbContext
    {
        public Adressboken()
            : base("name=Adressboken")
        {

        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Adress> Adress { get; set; }
        public DbSet<Epost> Epost { get; set; }
        public DbSet<Telefon> Telefon { get; set; }
        public DbSet<Kontakt> Kontakt { get; set; }
    }
}