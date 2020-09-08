using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace udvælgelse_af_elementer_fra_lister
{
    class Program
    {
        public static void PrinNumber(List<int> listNr)
        {

            foreach (var item in listNr)
            {
                Console.WriteLine("list of number:" + item);
            }
        }

        private static void PrintList(List<int> listA)
        {
            foreach (var item in listA)
            {
                Console.WriteLine("List:" + item);
            }
        }
        static void Main(string[] args)
        {
            //Opgave A:


            List<int> listNr = new List<int>() { 4, 7, 12, 17, -3, 8, 0, -45, 101 };


            PrinNumber(listNr);


            //list tal mindre end eller lig 0:

            List<int> listA = listNr.Where(number => number <= 0).ToList();

            //foreach (var item in listA)
            //{
            //    Console.WriteLine("List of number less than or equal to 0 :" + item);
            //}

            PrintList(listA);


            List<int> listB = listNr.Where(number => number == 7).ToList();

            //foreach (var item in listB)
            //{
            //    Console.WriteLine("List of number equal to 7 : " + item);
            //}

            PrintList(listB);


            List<int> listC = listNr.Where(number => number > 4).ToList();

            //foreach (var item in listC)
            //{
            //    Console.WriteLine("List of number greater than 4 : " + item);
            //}

            PrintList(listC);



            // Opgave B:

            car c1 = new car() { Id = 1, Model = "Rio", Brand = "Kia", Year = 2006, Price = 250000, Color = "Red" };
            car c2 = new car() { Id = 2, Model = "Rio", Brand = "Kia", Year = 2007, Price = 265000, Color = "Black" };
            car c3 = new car() { Id = 3, Model = "Panda", Brand = "Fiat", Year = 2017, Price = 265000, Color = "Black" };
            car c4 = new car() { Id = 4, Model = "Panda", Brand = "Fiat", Year = 2017, Price = 365000, Color = "Yellow" };
            car c5 = new car() { Id = 5, Model = "S40", Brand = "Volvo", Year = 2018, Price = 665000, Color = "White" };
            car c6 = new car() { Id = 6, Model = "S65", Brand = "Volvo", Year = 2018, Price = 600000, Color = "White" };
            car c7 = new car() { Id = 7, Model = "Gorm", Brand = "Ferrari", Year = 2000, Price = 4665000, Color = "White" };
            car c8 = new car() { Id = 8, Model = "Gorm", Brand = "Ferrari", Year = 2018, Price = 4665000, Color = "White" };


            List<car> listCar = new List<car>() { c1, c2, c3, c4, c5, c6, c7, c8 };

            List<car> listRio = listCar.Where(car => car.Model == "Rio").ToList();

            foreach (var item in listRio)
            {
                Console.WriteLine("List of Rio Model:" + item.ToString());
            }


            List<car> listFerrari = listCar.Where(car => car.Brand == "Ferrari").ToList();

            foreach (var item in listFerrari)
            {
                Console.WriteLine("List of Ferrari Brand:" + item.ToString());
            }


            List<car> listYear = listCar.Where(car => car.Year > 2010).ToList();

            foreach (var item in listYear)
            {
                Console.WriteLine("List of Year older than 2010:" + item.ToString());
            }


            List<car> listColor = listCar.Where(car => car.Color == "White").ToList();

            foreach (var item in listColor)
            {
                Console.WriteLine("List of White Color:" + item.ToString());
            }


            car carid = listCar.SingleOrDefault(car => car.Id == 8);


            Console.WriteLine("Car with Id 8 :" + carid.ToString());


            Console.ReadKey();
        }

        
    }
}







