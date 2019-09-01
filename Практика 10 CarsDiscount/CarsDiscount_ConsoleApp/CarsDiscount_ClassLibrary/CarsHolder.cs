using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsDiscount_ClassLibrary
{
    public class CarsHolder
    {        
        static List<Car> CarsList;

        static CarsHolder()
        {
            CarsList = new List<Car>();
        }

        public static void AddCar(Car newCar)
        {
            CarsList.Add(newCar);
        }

        public static Car[] GetCar
        {
            get
            {
                return CarsList.ToArray();
            }
        }
    }
}
