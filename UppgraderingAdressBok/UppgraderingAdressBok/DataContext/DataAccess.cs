using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UppgraderingAdressBok.DataContext
{
    public class DataAccess
    {
        public void NyPerson(string förnamn, string efternamn, string gatunamn, string postnummer, string postort,
            int riktnummer, string telefonnummer, string eposts, int kontakttyp)
        {
            using (var db = new Adressboken())
            {
                var person = new Person()
                {
                    Förnamn = förnamn,
                    Efternamn = efternamn,
                    Kontakt = kontakttyp
                };

                var adress = new Adress()
                {                   
                 //   PersonID = person.PersonID,                
                    Gatunamn = gatunamn,
                    Postnummer = postnummer,
                    Postort = postort
                };

                var telefon = new Telefon()
                {
                  //  PersonID = person.PersonID,
                    Riktnummer = riktnummer,
                    Telefonnummer = telefonnummer
                };

                var epost = new Epost()
                {
                 //   PersonID = person.PersonID,
                    Epostaddress = eposts
                };
                db.Person.Add(person);
                db.Adress.Add(adress);
                db.Telefon.Add(telefon);
                db.Epost.Add(epost);
                db.SaveChanges();
            }
        }

        public BindingList<Model.Person> SkapaNyPerson(int kontaktTyp, string namn, string efternamn)
        {
            BindingList<Model.Person> skapaPerson;

            using (var db = new Adressboken())
            {
                var person = new Person { Kontakt = kontaktTyp, Förnamn = namn, Efternamn = efternamn };
                db.Person.Add(person);
                db.SaveChanges();

                var query = from p in db.Person
                            select new Model.Person
                            {
                                Förnamn = namn,
                                Efternamn = efternamn
                            };
                skapaPerson = new BindingList<Model.Person>(query.ToList());
            }
            return skapaPerson;
        }

        public BindingList<Model.Adress> SkapaNyAddress(string gatuadress, string postnummer, string postort)
        {
            BindingList<Model.Adress> skapaAdressLista;

            using (var db = new Adressboken())
            {
                var adress = new Adress { Gatunamn = gatuadress, Postnummer = postnummer, Postort = postort };
                db.Adress.Add(adress);
                db.SaveChanges();

                var query = from a in db.Adress
                            select new Model.Adress
                            {
                                Gatunamn = gatuadress,
                                Postnummer = postnummer,
                                Postort = postort
                            };
                skapaAdressLista = new BindingList<Model.Adress>(query.ToList());
            }
            return skapaAdressLista;
        }

        public BindingList<Model.Epost> SkapaNyEpost(string epost)
        {
            BindingList<Model.Epost> skapaEpost;

            using (var db = new Adressboken())
            {
                var epostar = new Epost { Epostaddress = epost };
                db.Epost.Add(epostar);
                db.SaveChanges();

                var query = from a in db.Epost
                            select new Model.Epost
                            {
                                Epostaddress = epost
                            };
                skapaEpost = new BindingList<Model.Epost>(query.ToList());
            }
            return skapaEpost;
        }

        public BindingList<Model.Telefon> SkapaNyTelefon(int riktnummer, string telefonnummer)
        {
            BindingList<Model.Telefon> skapaEpost;

            using (var db = new Adressboken())
            {
                var nummer = new Telefon { Riktnummer = riktnummer, Telefonnummer = telefonnummer };
                db.Telefon.Add(nummer);
                db.SaveChanges();

                var query = from a in db.Telefon
                            select new Model.Telefon
                            {
                                Riktnummer = riktnummer,
                                Telefonnummer = telefonnummer
                            };

                skapaEpost = new BindingList<Model.Telefon>(query.ToList());
            }
            return skapaEpost;
        }

        public BindingList<Model.Adress> SökPåAdress(string gatunamn)
        {
            BindingList<Model.Adress> adress;

            using (var db = new Adressboken())
            {

                var query1 = db.Adress.SqlQuery($"select * from db.Adress where Gatunamn = \'%{gatunamn}%\'");

                var query = from a in db.Adress
                            where (a.Gatunamn.Contains(gatunamn))
                            select new Model.Adress
                            {
                                Gatunamn = a.Gatunamn,
                                Postnummer = a.Postnummer,
                                Postort = a.Postort
                            };

                adress = new BindingList<Model.Adress>(query.ToList());
            }
            return adress;
        }


        public BindingList<Model.Adress> LäggTillAdress(int id, string gatuadress, string postnummer, string postort)
        {
            BindingList<Model.Adress> skapaAdressLista;
                using (var db = new Adressboken())
                {
                    var adress = new Adress { Gatunamn = gatuadress, Postnummer = postnummer, Postort = postort };
                    db.Adress.Add(adress);
                    db.SaveChanges();

                    var query = from a in db.Adress
                                where a.ID == id
                                select new Model.Adress
                                {
                                    ID = id,
                                    Gatunamn = gatuadress,
                                    Postnummer = postnummer,
                                    Postort = postort
                                };
                    skapaAdressLista = new BindingList<Model.Adress>(query.ToList());
                }
                return skapaAdressLista;   
        }


        //public BindingList<Model.Adress> TaBortValdAdress(int id, string gatunamn, string postnummer, string postort)
        //{
        //    BindingList<Model.Adress> tabort;

        //    using (var db = new Adressboken())
        //    {
        ////        var adress = new Adress { ID = id, Gatunamn = gatunamn, Postnummer = postnummer, Postort = postort };
        ////        db.Adress.Remove(adress);
        ////        db.SaveChanges();

        //        var query = from a in db.Adress
        //                    where a.ID == id
        //                    select new Model.Adress
        //                    {
        //                        ID = id,
        //                        Gatunamn = gatunamn,
        //                        Postnummer = postnummer,
        //                        Postort = postort
        //                    };
        //        tabort = new BindingList<Model.Adress>(query.ToList());
        //    }
        //}
    }
}
