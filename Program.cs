using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            LightWeightCar lightCar1 = new LightWeightCar(2001, "Vaz", "Red", 200000, 0.9, 5);
            LightWeightCar lightCar2 = new LightWeightCar(2001, "Vaz", "Green", 200000, 0.9, 5, 10000);
            HeaviWeightCar heaviCar1 = new HeaviWeightCar(1990, "Zil", "Blue", 350000, 0.8, 3000);

            //Console.WriteLine(lightCar1.Equals(lightCar2));
            //Console.WriteLine(lightCar1.GetHashCode());
            //Console.WriteLine(lightCar2.GetHashCode());
            //Console.WriteLine(lightCar1.GetDiscount(card:"Gold"));
            //Console.WriteLine(lightCar2.GetDiscount());
            //Console.WriteLine(heaviCar1.GetCapacity());
            //Console.WriteLine(lightCar2.GetMileage());

            //lightCar1.GetViewCar();
            //heaviCar1.GetViewCar();

            bool result;
            if(result = lightCar1 > heaviCar1)
            Console.WriteLine("1 > 2 ");
            else if (result = lightCar1 < heaviCar1)
                Console.WriteLine("1 < 2 ");
            else if (result = lightCar1 == heaviCar1)
                Console.WriteLine("1 == 2 ");
            else
                Console.WriteLine("Invalid rezult.");



            //Console.WriteLine(BaseCar.GetCountCar());


            Console.ReadKey();
        }
    }
}
