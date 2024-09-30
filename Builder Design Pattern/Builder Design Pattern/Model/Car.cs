using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.Model
{
    internal class Car
    {
        public string Engine { get; set; }
        public string Wheels { get; set; }
        public string Seats { get; set; }
        public string GPS { get; set; }

        public override string ToString()
        {
            return $"Engine: {Engine}, Wheels: {Wheels}, Seats: {Seats}, GPS: {GPS}";
        }
    }
}
