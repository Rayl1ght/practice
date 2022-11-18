using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Misha1;

namespace Misha1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ApplicationContext db = new ApplicationContext())
            {
                var zakazi = db.Zakaz.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Zakaz u in zakazi)
                {
                    Console.WriteLine(u.ID + " - " + u.IDyslugi + " - " + u.IDclenta + " - " + u.IDtipazakaza + " - " + u.IDsotrudnika);
                }
            }
            using (ApplicationContext db = new ApplicationContext())
            {
                Zakaz test = new Zakaz { ID = 3, IDyslugi = 1, IDclenta = 1, IDtipazakaza = 1, IDsotrudnika = 1 };
                db.Zakaz.Add(test);
                db.SaveChanges();
                var zakazi = db.Zakaz.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Zakaz u in zakazi)
                {
                    Console.WriteLine(u.ID + " - " + u.IDyslugi + " - " + u.IDclenta + " - " + u.IDtipazakaza + " - " + u.IDsotrudnika);
                }

            }

            using (ApplicationContext db = new ApplicationContext())
            {
                Zakaz upduser = (from zakaz in db.Zakaz where zakaz.ID == 3 select zakaz).First();
                if (upduser != null)
                {
                    upduser.IDyslugi = 2;
                    db.SaveChanges();
                }
                var zakazi = db.Zakaz.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Zakaz u in zakazi)
                {
                    Console.WriteLine(u.ID + " - " + u.IDyslugi + " - " + u.IDclenta + " - " + u.IDtipazakaza + " - " + u.IDsotrudnika);
                }

            }

            using (ApplicationContext db = new ApplicationContext())
            {
                Zakaz deluser = (from zakaz in db.Zakaz where zakaz.ID == 3 select zakaz).First();
                if (deluser != null)
                {
                    db.Zakaz.Remove(deluser);
                    db.SaveChanges();
                }
                var zakazi = db.Zakaz.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Zakaz u in zakazi)
                {
                    Console.WriteLine(u.ID + " - " + u.IDyslugi + " - " + u.IDclenta + " - " + u.IDtipazakaza + " - " + u.IDsotrudnika);
                }

            }
            using (ApplicationContext db = new ApplicationContext())
            {
                var klients = db.Klient.ToArray();
                var zakaz = db.Zakaz.Where(c => c.ID == 3).FirstOrDefault();
                Klient klient = new Klient { Client_ID = 3, FIO_clienta = "Ура", Telefon_clienta = "321321", ZakazID = 3, Zakaz = zakaz };


                db.Klient.Add(klient);

                db.SaveChanges();
                var Klients = db.Klient.ToArray();
                foreach (Klient u in Klients)
                {
                    Console.WriteLine(u.Client_ID + " - " + u.FIO_clienta + " - " + u.Telefon_clienta + " - " + u.ZakazID);
                }
            }

            using (ApplicationContext db = new ApplicationContext())
            {
                Klient upduser = (from klient in db.Klient where klient.Client_ID == 2 select klient).First();
                if (upduser != null)
                {
                    upduser.FIO_clienta = "993-7";
                    db.SaveChanges();
                }
                var klients = db.Klient.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Klient u in klients)
                {
                    Console.WriteLine(u.Client_ID + " - " + u.FIO_clienta + " - " + u.Telefon_clienta + " - " + u.ZakazID);
                }

            }

            using (ApplicationContext db = new ApplicationContext())
            {
                Klient deluser = (from klient in db.Klient where klient.Client_ID == 3 select klient).First();
                if (deluser != null)
                {
                    db.Klient.Remove(deluser);
                    db.SaveChanges();
                }
                var klients = db.Klient.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Klient u in klients)
                {
                    Console.WriteLine(u.Client_ID + " - " + u.FIO_clienta + " - " + u.Telefon_clienta + " - " + u.ZakazID);
                }

            }


        }
    }
}

 