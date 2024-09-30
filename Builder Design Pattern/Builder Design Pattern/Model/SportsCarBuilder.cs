using Builder_Design_Pattern.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.Model
{
    internal class SportsCarBuilder:ICarBuilder
    {
        private Car _car = new Car();

        public void SetEngine()
        {
            _car.Engine = "V8 Engine";
        }

        public void SetWheels()
        {
            _car.Wheels = "Sports Wheels";
        }

        public void SetSeats()
        {
            _car.Seats = "Leather Seats";
        }

        public void SetGPS()
        {
            _car.GPS = "Advanced GPS";
        }

        public Car GetCar()
        {
            return _car;
        }
    }
}
