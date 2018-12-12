using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Car
    {
        private int Speed;
        private string Make;
        private string Model;
        private int Year;

        public Car(string Make, string Model, int Year, int Speed)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Speed = Speed;
        }

        public Car(string Make, string Model, int Year): this (Make, Model, Year, 0){}
        
        public int SpeedUp()
        {
            
            {
                return Speed++;
            }
        
        }
                
        public int SlowDown()
        {
            if (Speed > 0)
            {
                return Speed--;
            }
            return 0; 
        }

        public void Display()
        {
            Console.WriteLine(Year + " " + Make + " " + Model + " is going " + Speed + " MPH.");
        }



    }
}
