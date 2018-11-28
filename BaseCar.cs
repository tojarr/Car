using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    partial class BaseCar
    {
        public DateTime Year;
        protected string _Model;
        protected string _Color;
        protected int _Mileage;
        protected double _Price;
        protected readonly double _Discount;
        static int _CarCount = 0;
        const string _ConstColor = "Red";


        public BaseCar(int year, string model, double price, double discount, int mileage)
            : this(year, model, price, discount, mileage, _ConstColor)
        {

        }

        public BaseCar(int year, string model, double price, double discount, int mileage, string color)
        {
            if (year > 1900 & year < 2020)
            {
                Year = new DateTime(year, 01, 01);
            }
            else
            {
                Console.WriteLine("Invalid Year");
                Year = new DateTime(2000, 01, 01);
            }

            _Model = model;
            _Color = color;
            _Price = price;
            _Discount = discount;
            _Mileage = mileage;
            _CarCount++;
        }


        public string GetColor()
        {
            return _Color;
        }

        public int GetMileage()
        {
            return _Mileage;
        }

        public virtual double GetDiscount()
        {
            return _Price * _Discount;
        }

        public virtual double GetDiscount(string card)
        {
            card = card.ToLower();
            if (card == "premium")
                return GetDiscount() - 0.1;
            else if (card == "gold")
                return GetDiscount() - 0.2;
            else
                return GetDiscount();
        }

        static public int GetCountCar()
        {
            return _CarCount;
        }
    }
}
