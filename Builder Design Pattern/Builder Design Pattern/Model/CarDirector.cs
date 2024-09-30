using Builder_Design_Pattern.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.Model
{
    internal class CarDirector
    {
        private ICarBuilder _carBuilder;

        public CarDirector(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public void BuildCar()
        {
            _carBuilder.SetEngine();
            _carBuilder.SetWheels();
            _carBuilder.SetSeats();
            _carBuilder.SetGPS();
        }

        public Car GetCar()
        {
            return _carBuilder.GetCar();
        }
    }
}
