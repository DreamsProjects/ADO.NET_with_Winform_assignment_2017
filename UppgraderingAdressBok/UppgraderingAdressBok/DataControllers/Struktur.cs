using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UppgraderingAdressBok.DataContext;

namespace UppgraderingAdressBok.DataControllers
{
    public static class Struktur
    {
        public static void NyPerson(int kontakt, string förnamn, string efternamn, string gatunamn, string postnummer, string postort, int riktnummer, string telefonnummer, string email)
        {
            try
            {
                DataAccess access = new DataAccess();
                access.NyPerson(förnamn,efternamn,gatunamn,postnummer,postort,riktnummer,telefonnummer,email, kontakt);
                //access.SkapaNyPerson(kontakt, förnamn, efternamn);
                //access.SkapaNyAddress(gatunamn, postnummer, postort);
                //access.SkapaNyTelefon(riktnummer, telefonnummer);
                //access.SkapaNyEpost(email);
              //  access.SkapaNyKontakt(kontakt);
            }
            catch (FormatException)
            {
                MessageBox.Show("Någonting i textraderna stämmer inte");
            }
            finally
            {
                MessageBox.Show("Personen är sparad!");
            }
        }

        public static void SökAdress(string gatunamn)
        {
            DataAccess access = new DataAccess();
            access.SökPåAdress(gatunamn);
        }


        public static void LäggTillAdress(int id, string gatunamn, string postnummer, string postort)
        {
            try
            {
            DataAccess access = new DataAccess();
            access.LäggTillAdress(id, gatunamn, postnummer, postort);
            }
            catch(FormatException)
            {
                MessageBox.Show("Någonting gick snett, pröva ett annat ID");
            }
            finally
            {
                MessageBox.Show("Adressen sparad!");
            }
        }
    }
}
