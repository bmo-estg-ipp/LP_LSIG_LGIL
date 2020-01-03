using System;
namespace ExemploClasses3ComFicheiros
{
    [Serializable]
    public class Car
    {
        private string color;
        private string model;

        public Car(string color, string model)
        {
            this.color = color;
            this.model = model;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public string getColor()
        {
            return this.color;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public string getModel()
        {
            return this.model;
        }
    }
}
