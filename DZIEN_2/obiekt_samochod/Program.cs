using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiekt_samochod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto car = new Auto();
            car.kolorkaroserii = "czerwony";
            Console.WriteLine($"kolor karoserii: {car.kolorkaroserii}");
            Console.WriteLine(car.info("samochód do jazdy po mieście.."));
            Console.WriteLine($"dane samochodu: {car.dane()}");

            Auto truck = new Auto();
            Console.WriteLine($"kolor karoserii: {truck.kolorkaroserii}");
            Console.WriteLine(truck.info("mała ciężarówka.."));

            Auto suv = new Auto("Nissan","Patrol",3.8,2018);
            Console.WriteLine($"kolor karoserii: {suv.kolorkaroserii}");
            Console.WriteLine(suv.info("samochód do jazdy w terenie.."));
            Console.WriteLine($"dane samochodu: {suv.dane()}");

            Auto cross = new Auto(12.8,6.13);

            Console.ReadKey();  
        }
    }
}
