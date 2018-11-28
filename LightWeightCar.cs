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
        const double _DiscountLightWeightCar = 0.01;
        const double _DiscountBadMonth = 0.1;
        int _Month;

        public LightWeightCar(int year, string model, double price, double discount, int passenger
            , int mileage = 0)
            : base(year, model, price, discount, mileage)
        {
            _Passenger = passenger;
            DateTime now = DateTime.Now;
            _Month = now.Month;
        }

        public LightWeightCar(int year, string model, string color, double price, double discount, int passenger
            , int mileage = 0)
            : base(year, model, price, discount, mileage, color)
        {
            _Passenger = passenger;
            DateTime now = DateTime.Now;
            _Month = now.Month;
        }

        

        public int GetPassenger()
        {
            return _Passenger;
        }

        public override double GetDiscount()
        {
            if(_Month == 2)
                return _Price * (_Discount - (_DiscountBadMonth * _Month));
            return _Price * (_Discount - (_DiscountLightWeightCar * _Month));
        }

        public override double GetDiscount(string card)
        {
            card = card.ToLower();
            if (card == "premium")
                return (GetDiscount() * 0.9);
            else if (card == "gold")
                return (GetDiscount() * 0.8);
            else
                return GetDiscount();
        }

        public override void GetViewCar()
        {
            Console.WriteLine("Год выпуска - {0}", Year.Year);
            Console.WriteLine("Модель - {0}", _Model);
            Console.WriteLine("Цвет - {0}", _Color);
            Console.WriteLine("Пробег - {0}", _Mileage);
            Console.WriteLine("Цена - {0}", _Price);
            Console.WriteLine("К-во пасажиров - {0}", _Passenger);
        }
    }
}

