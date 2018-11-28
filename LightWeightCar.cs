using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class LightWeightCar : BaseCar, ILightWeightCar
    {
        int _Passenger;
        const double _DiscountLightWeightCar = 0.1;

        public LightWeightCar(int year, string model, string color, double price, double discount, int passenger
            , int mileage = 0)
            : base(year, model, color, price, discount, mileage)
        {
            _Passenger = passenger;
        }

        

        public int GetPassenger()
        {
            return _Passenger;
        }

        public override double GetDiscount(string card)
        {
            card = card.ToLower();
            if (card == "premium")
                return _Price * (_Discount - (_DiscountLightWeightCar + 0.1));
            else if (card == "gold")
                return _Price * (_Discount - (_DiscountLightWeightCar + 0.2));
            else
                return GetDiscount();
        }

        public override void GetViewCar()
        {
            Console.WriteLine("Год выпуска - {0}", _Year);
            Console.WriteLine("Модель - {0}", _Model);
            Console.WriteLine("Цвет - {0}", _Color);
            Console.WriteLine("Пробег - {0}", _Mileage);
            Console.WriteLine("Цена - {0}", _Price);
            Console.WriteLine("К-во пасажиров - {0}", _Passenger);
        }
    }
}

