using Builder_Design_Pattern.Intefaces;
using Builder_Design_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarBuilder sportsCarBuilder=new SportsCarBuilder();
            CarDirector sportsCarDirector=new CarDirector(sportsCarBuilder);
            sportsCarDirector.BuildCar();
            Car sportsCar=sportsCarDirector.GetCar();
            Console.WriteLine("Sports Car:"+sportsCar);

            ICarBuilder suvCarBuilder=new SUVCarBuilder();
            CarDirector suvCarDirector=new CarDirector(suvCarBuilder);
            suvCarDirector.BuildCar();
            Car suvCar=suvCarDirector.GetCar();
            Console.WriteLine("SUV Car:"+suvCar);
        }
    }
}
