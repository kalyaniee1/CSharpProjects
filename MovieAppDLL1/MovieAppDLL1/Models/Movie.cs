using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppDLL1.Models
{
    [Serializable]
    public class Movie
    {
        string _name, _genre, _yearOfRelease;
        string _id;
        public Movie(string name, string genre, string yearOfRelease)
        {
            _name = name;
            _genre = genre;
            _yearOfRelease = yearOfRelease;
            _id=_name.Substring(0,1)+_genre.Substring(0,1)+_yearOfRelease.Substring(2,2);
        }

        public string Name { get { return _name;} set { _name = value; } }
        public String YearOfRelease { get { return _yearOfRelease; } set { _yearOfRelease = value; } }
        public string Genre { get { return _genre; } set { _genre = value; } }       

        public String Id { get { return _id; } }
    }
}
