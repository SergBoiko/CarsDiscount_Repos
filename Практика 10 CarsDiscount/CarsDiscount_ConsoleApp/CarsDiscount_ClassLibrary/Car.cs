using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsDiscount_ClassLibrary
{
    public partial class Car
    {
        public Car(string color, string name, double price, int discount)
        {
            this.Color = color;
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
        }


        public double Price { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }

        private double price;
        private string color;
        private string name;

        private int discount = 10;


       

        public int Discount
        {
            get
            {
                if (Color.Equals("Red"))
                {
                    return discount + 20;
                }

                else if (Color.Equals("Black"))
                {
                    return discount + 30;
                }

                else if (Color.Equals("White"))
                {
                    return discount + 15;
                }

                return discount;                
            }

            set
            {
                if(value <= 50)
                {
                    discount = value;
                }
                else
                {
                    Console.WriteLine("Wrong discount");
                    discount = 0;
                }
            }
        }
    }
}
