using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    partial class BaseCar
    {
        protected int _Year;
        protected string _Model;
        protected string _Color;
        protected int _Mileage;
        protected double _Price;
        protected double _Discount;
        static int _CarCount = 0;




        public BaseCar(int year, string model, string color, double price, double discount, int mileage)
        {
            if (year > 1900 & year < 2020)
            {
                _Year = year;
            }
            else
            {
                Console.WriteLine("Invalid Year");
                _Year = 2000;
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

        public double GetDiscount()
        {
            return _Price * _Discount;
        }

        public virtual double GetDiscount(string card)
        {
            card = card.ToLower();
            if (card == "premium")
                return _Price * (_Discount - 0.1);
            else if (card == "gold")
                return _Price * (_Discount - 0.2);
            else
                return GetDiscount();
        }

        static public int GetCountCar()
        {
            return _CarCount;
        }
    }
}
