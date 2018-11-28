using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    abstract partial class BaseCar
    {
        public override bool Equals(object obj)
        {
            if (!(obj is BaseCar))
                return false;

            BaseCar car = (BaseCar)obj;
            return (car._Model == this._Model && car._Year == this._Year);
        }

        public override int GetHashCode()
        {
            return this._Model.GetHashCode() ^ this._Year.GetHashCode();
        }


        abstract public void GetViewCar();


        public static bool operator >(BaseCar c1, BaseCar c2)
        {
            return c1._Price > c2._Price;
        }
        public static bool operator <(BaseCar c1, BaseCar c2)
        {
            return c1._Price < c2._Price;
        }
        public static bool operator ==(BaseCar c1, BaseCar c2)
        {
            return c1._Price == c2._Price;
        }
        public static bool operator !=(BaseCar c1, BaseCar c2)
        {
            return c1._Price != c2._Price;
        }
    }
}
