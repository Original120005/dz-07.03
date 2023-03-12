using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz07_03
{
    class Firma
    {
        public string name { get; set; }
        public int year { get; set; }
        public string type { get; set; }
        public string director_full_name { get; set; }
        public string adress { get; set; }
        public int employees_amount { get; set; }

        public Firma() { }
        public Firma(string name, int year, string type, string director_full_name, string adress, int employees_amount)
        {
            this.name = name;
            this.year = year;
            this.type = type;
            this.director_full_name = director_full_name;
            this.adress = adress;
            this.employees_amount = employees_amount;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Firma> firmas = new List<Firma>()
            {
                new Firma("gaijm", 1966, "game", "Mikle Scoffielt", "Goaaga", 14),
                new Firma("Lays", 1998, "food", "Alex stil", "Kiev", 15),
                new Firma("ford", 1931, "cars", "Jorj Ford", "Florida", 435),
                new Firma("Adidas", 1965, "shoes", "Fill Nite", "Load", 72),
                new Firma("Porshe", 1939, "Cars", "Jon Porshe", "Berlin", 205),
                new Firma("Pokemon go", 2018, "marketing", "Tooashiba makito", "Bejin", 89)
            };

            //ex1
            var all_firmas = from firma in firmas 
                             select firma;
            foreach(var firm in all_firmas) { 
                Console.WriteLine("{0} ({1})\nType: {2}\nDirector: {3}\nPlace: {4}\nAmount: {5}\n\n", firm.name, firm.date, firm.type, firm.director_full_name, firm.adress, firm.employees_amount);
            }

            // Метод расширений
            var all_firmas = from firma in firmas
                             select firma.name;
            all_firmas = firmas.Select(f => f.name);
            foreach (var n in all_firmas) { 
                Console.WriteLine(n);
            }
            

            //ex2
            /*var search_name = from firm in firmas
                              where firm.name.Contains("Food") 
                              select firm;
            foreach(var firm in search_name) { 
                Console.WriteLine("{0}", firm.name);
            }*/
            

            //ex3
            /*var search_type = from firma in firmas
                              where firma.type == "marketing"
                              select firma;
            foreach(var i in search_type) {
                Console.WriteLine(i.name);
            }*/
            

            //ex4
            /*var search_type = from firma in firmas
                              where firma.type == "marketing" || firma.type == "it"
                              select firma;
            foreach(var i in search_type) {
                Console.WriteLine(i.name);
            }*/
            

            //ex5
            /*var amount_employees = from firma in firmas
                                   where firma.employees_amount > 100
                                   select firma;
            foreach(var i in amount_employees) {
                Console.WriteLine(i.name);
            }*/
            

            //ex6
            /*var amount_employees = from firma in firmas
                                  where firma.employees_amount >= 100 && firma.employees_amount <= 300
                                  select firma;
           foreach(var i in amount_employees) {
               Console.WriteLine(i.name);
           }*/
            

            //ex7
            /*var search_london = from firma in firmas
                                where firma.adress == "London"
                                select firma;
            foreach(var i in search_london) {
                Console.WriteLine("{0} - London", i.name);
            }*/
            

            //ex8
            /*var search_surname = from firma in firmas
                                 where firma.director_full_name.Contains("White")
                                 select firma;
            foreach (var i in search_surname) {
                Console.WriteLine(i.name);
            }*/
            

            //ex9
            /*var search_firm = from firm in firmas
                              where firm.year < 2021
                              select firm;
            foreach (var i in search_firm) {
                Console.WriteLine(i.name);
            }*/
            

            //ex10
            /*var search_director = from firma in firmas
                                  where firma.director_full_name.Contains("Black") && firma.name.Contains("White")
                                  select firma;
            foreach (var i in search_director) {
                Console.WriteLine(i.name);
            }*/
            



        }
    }
}