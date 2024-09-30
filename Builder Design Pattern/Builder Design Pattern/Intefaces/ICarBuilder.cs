using Builder_Design_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.Intefaces
{
    internal interface ICarBuilder
    {
        void SetEngine();
        void SetWheels();
        void SetSeats();
        void SetGPS();
        Car GetCar();
    }
}
