using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Rectangle
    {
        float _height,_width;
        string _color;

        public Rectangle() : this(5f, 4.5f, "Black")
        {
            //this._height = 4;
            //this._width = 4.5f;
            //_color = "Black";
        }
        public Rectangle(float height,float width) : this(height,width, "Black")
        {
            //this._height = height;
            //this._width = width;
            //_color = "Black";
        }
        public Rectangle(float height, float width,string color)
        {
            this._height = height;
            this._width = width;
            this._color = color;
        }
        public float Height
        {
            get
            {

                return _height;
            }
        }

            public float Width
        {
            
            get
            {

                return _width;
            }
        }
        public string Color
        {

            get
            {

                return _color;
            }
            set { _color = value; }
        }

        public double CalculateArea() { 
            return Height * Width;
        }
        
    }
}
