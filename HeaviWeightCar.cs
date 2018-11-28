using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class HeaviWeightCar : BaseCar, IHeaviWeightCar
    {
        int _LoadCapacity;
        const double _DiscountHeaviWeightCar = 0.2;

        public HeaviWeightCar(int year, string model, double price, double discount, int capacity,
            int mileage = 0)
            : base(year, model, price, discount, mileage)
        {
            _LoadCapacity = capacity;
        }

        public HeaviWeightCar(int year, string model, string color, double price, double discount, int capacity,
            int mileage = 0)
            : base(year, model, price, discount, mileage, color)
        {
            _LoadCapacity = capacity;
        }

        public int GetCapacity()
        {
            return _LoadCapacity;
        }

        public override double GetDiscount(string card)
        {
            card = card.ToLower();
            if (card == "premium")
                return _Price * (_Discount - (_DiscountHeaviWeightCar + 0.1));
            else if (card == "gold")
                return _Price * (_Discount - (_DiscountHeaviWeightCar + 0.2));
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
            Console.WriteLine("Грузоподьемность - {0}", _LoadCapacity);
        }
    }
}
