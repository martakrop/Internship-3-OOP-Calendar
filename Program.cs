
using System;
using System.Collections.Generic;

namespace Kalendar
{
    class Program
    {
        static void Main(string[] args)
        {

            var r1 = new Random();
            var r2 = new Random();
            var r3 = new Random();
            var r4 = new Random();
            var r5 = new Random();

            Events dogadaj1 = new Events(r1.Next(1000, 10000), "MIOC OPEN", "Krempijevo igralište", new DateTime(2022, 9, 10, 20, 0, 0), new DateTime(2022, 9, 10, 20, 50, 44), new List<string> { "ante-antic@gmail.com", "sasa-antic@gmail.com" });
            Events dogadaj2 = new Events(r2.Next(1000, 10000), "DUMP Internship", "FESB", new DateTime(2022, 11, 2, 13, 0, 0), new DateTime(2022, 11, 2, 16, 20, 10), new List<string> { "renata-peric123@gmail.com", "sasamatic-official@gmail.com", "pero.petar@gmail.com", "ante-antic@gmail.com" });
            Events dogadaj3 = new Events(r3.Next(1000, 10000), "ROĐENDAN", "Mall of Split", DateTime.Now, DateTime.Now.AddHours(3), new List<string> { "nika123@gmail.com", "perokralj123@gmail.com", "joviciva@gmail.com" });
            Events dogadaj4 = new Events(r4.Next(1000, 10000), "UTAKMICA", "Poljud", new DateTime(2023, 4, 10, 17, 0, 0), new DateTime(2023, 4, 10, 19, 12, 33), new List<string> { "perokralj123@gmail.com", "joviciva@gmail.com", "matematic123@gmail.com", "pero.petar@gmail.com" });
            Events dogadaj5 = new Events(r5.Next(1000, 10000), "MIOC CLOSED", "Krempijevo igralište", new DateTime(2022, 12, 25, 19, 0, 0), new DateTime(2022, 12, 25, 22, 0, 0), new List<string> { "perokralj123@gmail.com", "nikolic1@gmail.com", "renata-peric123@gmail.com", "ante-antic@gmail.com" });
            List<Events> ListOfEvents = new() { dogadaj1, dogadaj2, dogadaj3, dogadaj4, dogadaj5 };



            Person osoba1 = new("Ante", "Antić", "ante-antic@gmail.com", new Dictionary<int, bool> { { dogadaj1.Id, true }, { dogadaj2.Id, true }, { dogadaj3.Id, false }, { dogadaj4.Id, false }, { dogadaj5.Id, true } });
            Person osoba2 = new("Mate", "Matić", "matematic123@gmail.com", new Dictionary<int, bool> { { dogadaj1.Id, false }, { dogadaj2.Id, false }, { dogadaj3.Id, false }, { dogadaj4.Id, true }, { dogadaj5.Id, false } });
            Person osoba3 = new("Nika", "Nakić", "nika123@gmail.com", new Dictionary<int, bool> { { dogadaj1.Id, false }, { dogadaj2.Id, false }, { dogadaj3.Id, true }, { dogadaj4.Id, false }, { dogadaj5.Id, false } });
            Person osoba4 = new("Petar", "Petančić", "pero.petar@gmail.com", new Dictionary<int, bool> { { dogadaj1.Id, false }, { dogadaj2.Id, true }, { dogadaj3.Id, false }, { dogadaj4.Id, true }, { dogadaj5.Id, false } });
            Person osoba5 = new("Saša", "Antić", "sasa-antic@gmail.com", new Dictionary<int, bool> { { dogadaj1.Id, true }, { dogadaj2.Id, false }, { dogadaj3.Id, false }, { dogadaj4.Id, false }, { dogadaj5.Id, false } });
            Person osoba6 = new("Saša", "Matić", "sasamatic-official@gmail.com", new Dictionary<int, bool> { { dogadaj1.Id, false }, { dogadaj2.Id, true }, { dogadaj3.Id, false }, { dogadaj4.Id, false }, { dogadaj5.Id, false } });
            Person osoba7 = new("Iva", "Jović", "joviciva@gmail.com", new Dictionary<int, bool> { { dogadaj1.Id, false }, { dogadaj2.Id, false }, { dogadaj3.Id, true }, { dogadaj4.Id, true }, { dogadaj5.Id, false } });
            Person osoba8 = new("Nikola", "Nikolić", "nikolic1@gmail.com", new Dictionary<int, bool> { { dogadaj1.Id, false }, { dogadaj2.Id, false }, { dogadaj3.Id, false }, { dogadaj4.Id, true }, { dogadaj5.Id, true } });
            Person osoba9 = new("Renata", "Perić", "renata-peric123@gmail.com", new Dictionary<int, bool> { { dogadaj1.Id, false }, { dogadaj2.Id, false }, { dogadaj3.Id, false }, { dogadaj4.Id, false }, { dogadaj5.Id, true } });
            Person osoba10 = new("Petar", "Matić", "perokralj123@gmail.com", new Dictionary<int, bool> { { dogadaj1.Id, false }, { dogadaj2.Id, false }, { dogadaj3.Id, true }, { dogadaj4.Id, true }, { dogadaj5.Id, true } });
            List<Person> People = new() { osoba1, osoba2, osoba3, osoba4, osoba5, osoba6, osoba7, osoba8, osoba9, osoba10 };


            foreach (var dogadaj in ListOfEvents)
            {
                Console.WriteLine("");
                Console.Write(dogadaj.Id + " " + dogadaj.Location + " " + dogadaj.Name + " " + dogadaj.StartDate.ToShortDateString() + " " + dogadaj.EndDate.ToShortDateString() + " ");
                foreach (var mail in dogadaj.Emails)
                    Console.Write(mail + " ");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (var osoba in People)
            {
                Console.WriteLine("");
                Console.Write(osoba.FirstName + " " + osoba.LastName + " " + osoba.Email + " ");
                foreach (var pris in osoba.Presence)
                    Console.Write(pris.Key + " " + pris.Value + " ");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();




            int act;
            var InputParsed = false;
            do
            {
                
                Console.WriteLine("KALENDAR");
                Console.WriteLine("1 - Aktivni eventi");
                Console.WriteLine("2 - Nadolazeći eventi");
                Console.WriteLine("3 - Eventi koji su završili");
                Console.WriteLine("4 - Kreiraj event");
                Console.WriteLine("5 - Izađi iz programa");

                Console.WriteLine("\nIzaberi broj akcije: ");
                InputParsed = false;
                do
                {
                    bool parse = int.TryParse(Console.ReadLine(), out act);
                    if (parse == true)
                        InputParsed = true;
                }
                while (InputParsed == false);

                if (act < 1 || act > 5)
                {
                    Console.WriteLine("\nIzbor akcije nije ispravan - unesi broj akcije: ");
                }

                switch (act)
                {
                    case 1: // AKTIVNI EVENTI
                        {
                            Console.WriteLine("Aktivni eventi: ");
                            //ispis aktivnih 
                            foreach (var item in ListOfEvents)
                            {
                                if (item.StartDate >= DateTime.Now && item.EndDate <= DateTime.Now)
                                {
                                    Console.WriteLine($"ID: {item.Id} " +
                                        $"- IME: {item.Name} - LOKACIJA: {item.Location} - ZAVRŠAVA ZA:  {(item.EndDate - item.StartDate).TotalDays:f0}");
                                    Console.Write("Ispis sudionika: ");
                                    foreach (var per in item.Emails)
                                        Console.Write(per + ' ');
                                    Console.WriteLine();
                                }
                            }
                            //akcije vezane za aktivne evente
                            do
                            {
                                Console.WriteLine();
                                Console.WriteLine("Akcije: ");
                                Console.WriteLine("1 - Zabilježi neprisutnosti");
                                Console.WriteLine("2 - Povratak na glavni menu");
                                Console.WriteLine("\nUnesi broj akcije: ");
                                InputParsed = false;
                                do
                                {
                                    bool parse = int.TryParse(Console.ReadLine(), out act);
                                    if (parse == true)
                                        InputParsed = true;
                                } while (InputParsed == false);

                                if (act < 1 || act > 2)
                                {
                                    Console.WriteLine("\nIzbor akcije nije ispravan - unesi broj akcije: ");
                                }

                                if (act == 2)
                                    break;
                                else
                                {
                                    do
                                    {
                                        Console.WriteLine("\nNeprisutnosti: ");
                                        int myEventId;
                                        string myPersonEmail;
                                        Console.WriteLine("Unesi ID eventa za modifikaciju.");
                                        InputParsed = false;
                                        do
                                        {
                                            bool parse = int.TryParse(Console.ReadLine(), out myEventId);
                                            if (parse == true)
                                                InputParsed = true;
                                        } while (InputParsed == false);

                                        var modificirano = false;
                                        foreach (var item in ListOfEvents)
                                            if (item.Id == myEventId)
                                            {
                                                do
                                                {

                                                    Console.WriteLine("Unesi E-mail osobe kojoj želiš zabilježiti izostanak.");
                                                    myPersonEmail = Console.ReadLine();

                                                    var obrisano = false;
                                                    modificirano = true;
                                                    foreach (var mail in item.Emails)
                                                        if (mail == myPersonEmail)
                                                        {
                                                            item.Emails.Remove(mail);
                                                            Console.WriteLine("Zabilježeno je da osoba nije bila na eventu.");
                                                            obrisano = true;
                                                            break;
                                                        }

                                                    if (obrisano == true)
                                                    {
                                                        foreach (var osoba in People)
                                                            if (osoba.Email == myPersonEmail)
                                                            {
                                                                osoba.Presence[item.Id] = false;
                                                            }

                                                        break;
                                                    }
                                                    if (obrisano == false)
                                                    {
                                                        Console.WriteLine("Uneseni E-mail nije pridružen nijednoj osobi - Unesi opet.");
                                                        continue;
                                                    }


                                                } while (true);
                                            }

                                        if (modificirano == true)
                                            break;
                                        if (modificirano == false)
                                        {
                                            Console.WriteLine("Uneseni ID nije pridružen nijednom eventu - Unesi opet.");
                                            continue;
                                        }
                                    } while (true);

                                    do
                                    {
                                        Console.WriteLine("\nOdaberi 0 ako želiš izaći iz aplikacije. Odaberi 1 ako želiš nastaviti.");
                                        int youchose = 0;
                                        do
                                        {
                                            bool parse = int.TryParse(Console.ReadLine(), out youchose);
                                            if (parse == true)
                                                InputParsed = true;
                                        }
                                        while (InputParsed == false);

                                        if (youchose == 1)
                                        {
                                            var backOrContinue = 1;
                                            break;
                                        }
                                        else if (youchose == 0)
                                        {
                                            return;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nIzbor akcije nije ispravan - unesi broj akcije: ");
                                            continue;
                                        }
                                    } while (true);

                                    if (InputParsed = true)
                                    {
                                        break ;
                                    }
                                    else
                                        continue;

                                }
                            } while (true);
                            break;
                        }

                    


                    case 2: // NADOLAZECI EVENTI
                        {
                            Console.WriteLine("\nNadolazeći eventi: ");

                            foreach (var item in ListOfEvents)
                                if (item.StartDate > DateTime.Now)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine($"ID: {item.Id} " +
                                        $"- IME: {item.Name} - LOKACIJA: {item.Location} - DANA DO: {(item.StartDate - DateTime.Now).TotalDays:f0} - TRAJANJE:  {(item.EndDate - item.StartDate).TotalDays:f0}");
                                }
                            do
                            {
                                Console.WriteLine();
                                Console.WriteLine("Akcije: ");
                                Console.WriteLine("1 - Izbriši event");
                                Console.WriteLine("2 - Ukloni osobe s eventa");
                                Console.WriteLine("3 - Povratak na glavni menu");
                                InputParsed = false;
                                do
                                {
                                    bool parse = int.TryParse(Console.ReadLine(), out act);
                                    if (parse == true)
                                        InputParsed = true;
                                } while (InputParsed == false);

                                if (act < 1 || act > 3)
                                {
                                    Console.WriteLine("\nIzbor akcije nije ispravan - unesi broj akcije: ");
                                }

                                if (act == 3)
                                    break;

                                else if (act == 1)
                                {

                                    do
                                    {

                                        int deleteEvent;
                                        if (ListOfEvents.Count == 0)
                                        {
                                            Console.WriteLine("Lista događaja prazna .....");
                                            break;
                                        }
                                        Console.WriteLine("Unesi ID eventa kojeg želiš izbrisati: ");
                                        InputParsed = false;
                                        do
                                        {
                                            bool parse = int.TryParse(Console.ReadLine(), out deleteEvent);
                                            if (parse == true)
                                                InputParsed = true;
                                        } while (InputParsed == false);

                                        var izbrisano = false;

                                        //brisanje događaja
                                        foreach (var item in ListOfEvents)
                                            if (item.Id == deleteEvent)
                                            {
                                                ListOfEvents.Remove(item);
                                                Console.WriteLine("Event je izbrisan.");
                                                izbrisano = true;

                                                foreach (var osoba in People)
                                                    osoba.Presence[item.Id] = false;


                                                break;
                                            }
                                        if (izbrisano == true)
                                            break;

                                        if (izbrisano == false)
                                        {
                                            Console.WriteLine("Unešeni ID nije pridružen nijednom eventu. ");
                                            continue;
                                        }
                                    } while (true);
                                }


                                else if (act == 2)
                                {
                                    do
                                    {
                                        // brisanje osobe iz događaja

                                        int deleteEvent;
                                        Console.WriteLine("Unesi ID eventa s kojeg želiš izbrisati osobe: ");
                                        InputParsed = false;
                                        do
                                        {
                                            bool parse = int.TryParse(Console.ReadLine(), out deleteEvent);
                                            if (parse == true)
                                                InputParsed = true;
                                        } while (InputParsed == false);

                                        string deletePerson;
                                        bool obrisano = false;
                                        bool modificirano = false;
                                        foreach (var item in ListOfEvents)
                                            if (item.Id == deleteEvent)
                                            {
                                                modificirano = true;
                                                do
                                                {
                                                    if (item.Emails.Count == 0)
                                                    {
                                                        Console.WriteLine("Lista osoba prazna .....");
                                                        break;
                                                    }

                                                    Console.WriteLine("Unesi E-mail osobe koju želiš izbrisati: ");
                                                    do
                                                        deletePerson = Console.ReadLine();
                                                    while (deletePerson == null);

                                                    foreach (var pers in item.Emails)
                                                        if (Equals(pers, deletePerson) == true)
                                                        {
                                                            item.Emails.Remove(pers);
                                                            Console.WriteLine("Osoba je uklonjena s eventa");
                                                            foreach (var osoba in People)
                                                                osoba.Presence[item.Id] = false;
                                                            obrisano = true;
                                                            break;
                                                        }

                                                    if (obrisano == true)
                                                        break;
                                                    if (obrisano == false)
                                                    {
                                                        Console.WriteLine("Uneseno ime nije pridruženo eventu");
                                                        continue;
                                                    }
                                                } while (true);
                                            }

                                        if (modificirano == true)
                                            break;
                                        if (modificirano == false)
                                        {
                                            Console.WriteLine("Uneseni ID nije pridružen nijednom eventu.");
                                            continue;
                                        }
                                    } while (true);
                                }
                            } while (true);

                            do
                            {
                                Console.WriteLine("\nOdaberi 0 ako želiš izaći iz aplikacije. Odaberi 1 ako želiš nastaviti.");
                                int youchose = 0;
                                do
                                {
                                    bool parse = int.TryParse(Console.ReadLine(), out youchose);
                                    if (parse == true)
                                        InputParsed = true;
                                }
                                while (InputParsed == false);

                                if (youchose == 1)
                                {
                                    var backOrContinue = 1;
                                    break;
                                }
                                else if (youchose == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("\nIzbor akcije nije ispravan - unesi broj akcije: ");
                                    continue;
                                }
                            } while (true);

                            if (InputParsed = true)
                            {
                                break;
                            }
                            else
                                continue;

                            break;
                        }



                    case 3:
                        {

                            Console.WriteLine("Eventi koji su zavrsili: ");

                            foreach (var item in ListOfEvents)
                                if (item.EndDate < DateTime.Now)
                                {

                                    Console.WriteLine($"ID: {item.Id} " +
                                    $"- IME: {item.Name} - LOKACIJA: {item.Location} - ZAVRŠILO PRIJE: {Math.Abs((item.EndDate - DateTime.Now).TotalDays):f0} dana - TRAJANJE:  {(item.EndDate - item.StartDate).TotalHours:f0} h");
                                    
                                    Console.Write("\nIspis prisutnih sudionika: ");
                                    foreach (var per in item.Emails)
                                        Console.Write(per + ' ');
                                    Console.WriteLine();
                                    Console.Write("\nPopis ne prisutnih sudionika: ");
                                    foreach (var osoba in People)
                                    {
                                        foreach (var pris in osoba.Presence)
                                            if (pris.Key == item.Id && pris.Value == false)
                                                Console.Write(osoba.Email + ' ');
                                    }
                                    Console.WriteLine();

                                    do
                                    {
                                        Console.WriteLine("\nOdaberi 0 ako želiš izaći iz aplikacije. Odaberi 1 ako želiš nastaviti.");
                                        int youchose = 0;
                                        do
                                        {
                                            bool parse = int.TryParse(Console.ReadLine(), out youchose);
                                            if (parse == true)
                                                InputParsed = true;
                                        }
                                        while (InputParsed == false);

                                        if (youchose == 1)
                                        {
                                            var backOrContinue = 1;
                                            break;
                                        }
                                        else if (youchose == 0)
                                        {
                                            return;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nIzbor akcije nije ispravan - unesi broj akcije: ");
                                            continue;
                                        }
                                    } while (true);

                                    if (InputParsed = true)
                                    {
                                        break;
                                    }
                                    else
                                        continue;
                                }

                            break;
                        }



                    case 4:
                        {
                            Console.WriteLine("Kreiraj event: ");
                            Console.Write("Unesi naziv: ");
                            string newEventName = Console.ReadLine();
                            Console.Write("Unesi lokaciju: ");
                            string newEventLocation = Console.ReadLine();

                            DateTime newEventStart;
                            do
                            {
                                Console.Write("Unesi početak (u obliku DD.MM.YYYY.) : ");
                                newEventStart = DateTime.Parse(Console.ReadLine());
                            } while (newEventStart < DateTime.Now);

                            DateTime newEventEnd;
                            do
                            {
                                Console.Write("Unesi kraj (u obliku DD.MM.YYYY.) : ");
                                newEventEnd = DateTime.Parse(Console.ReadLine());
                            } while (newEventStart > newEventEnd);

                            Console.WriteLine("Unesi osobe koje žele biti prisutne na novom eventu: ");
                            var listPerson = Console.ReadLine();
                            var newListEmails = new List<string>();
                            string singlePerson = "";

                            foreach (var znak in listPerson)
                            {
                                if (znak == ' ')
                                {
                                    newListEmails.Add(singlePerson);
                                    singlePerson = "";
                                }
                                else
                                    singlePerson += znak;
                            }
                            newListEmails.Add(singlePerson);

                           

                            var r = new Random();
                            Events dogadaj = new(r.Next(1000, 10000), newEventName, newEventLocation, newEventStart, newEventEnd, newListEmails);
                            ListOfEvents.Add(dogadaj);

                            Console.WriteLine("Event je kreiran");


                            do
                            {
                                Console.WriteLine("\nOdaberi 0 ako želiš izaći iz aplikacije. Odaberi 1 ako želiš nastaviti.");
                                int youchose = 0;
                                do
                                {
                                    bool parse = int.TryParse(Console.ReadLine(), out youchose);
                                    if (parse == true)
                                        InputParsed = true;
                                }
                                while (InputParsed == false);

                                if (youchose == 1)
                                {
                                    var backOrContinue = 1;
                                    break;
                                }
                                else if (youchose == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("\nIzbor akcije nije ispravan - unesi broj akcije: ");
                                    continue;
                                }
                            } while (true);

                            if (InputParsed = true)
                            {
                                break;
                            }
                            else
                                continue;
                            break;
                        }

                    case 5:
                        return;

                }

            } while (true);

        }


    }
}