using System;
namespace ExemploClasses
{
    public class Car
    {
        private string color;

        public Car(string color)
        {
            this.color = color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return this.color;
        }
    }
}
