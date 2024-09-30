using Builder_Design_Pattern.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.Model
{
    internal class SUVCarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public void SetEngine()
        {
            _car.Engine = "V6 Engine";
        }

        public void SetWheels()
        {
            _car.Wheels = "All-terrain Wheels";
        }

        public void SetSeats()
        {
            _car.Seats = "Comfort Seats";
        }

        public void SetGPS()
        {
            _car.GPS = "Standard GPS";
        }

        public Car GetCar()
        {
            return _car;
        }
    }
}
