using System;

namespace ExemploClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //car instantiation
            Car myObj = new Car("black");
            //call getColor method
            Console.WriteLine(myObj.getColor());
            //change car color
            myObj.setColor("blue");
            Console.WriteLine(myObj.getColor());
        }
    }
}
