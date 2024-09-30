//using MovieApp.Models;
//using MovieApp.Services;
using MovieAppDLL1.Models;
using MovieAppDLL1.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    public class MovieStore
    {
        string _choice;
        List<Movie> movies;
        MovieManager _manager=new MovieManager();

        public MovieStore() { 
          
        }
        public void showMenu() {
            Console.WriteLine("Welcome to the movieApp!");
            while (_choice!="x") 
            {
                Console.WriteLine("1.Show movies");
                Console.WriteLine("2.Add a movie");
                Console.WriteLine("3.Delete a movie");
                Console.WriteLine("x.Exit");

                _choice=Console.ReadLine();

                if (_choice == "1")
                {
                    try
                    {
                        movies = _manager.ReadMovie();
                        foreach (Movie movie in movies)
                        {
                            Console.WriteLine("Movie ID: " + movie.Id);
                            Console.WriteLine("Movie Name: " + movie.Name);
                            Console.WriteLine("Movie Genre: " + movie.Genre);
                            Console.WriteLine("Movie year: " + movie.YearOfRelease);
                        }
                    }catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (_choice == "2")
                {
                    string _name, _genre, _yearOfRelease;
                    Console.WriteLine("Name of the movie:");
                    _name = Console.ReadLine();
                    Console.WriteLine("Genre:");
                    _genre = Console.ReadLine();
                    Console.WriteLine("Year of release:");
                    _yearOfRelease = Console.ReadLine();


                    Movie newMovie = new Movie(_name, _genre, _yearOfRelease);
                    _manager.AddMovie(newMovie);
                }
                else if (_choice == "3")
                {
                    Console.WriteLine("Enter the movie ID to be removed:");
                    string _Id = Console.ReadLine();
                    _manager.RemoveMovie(_Id);
                }
                else if(_choice=="x") {
                    Console.WriteLine("Byee..Until next time!");
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }
            }
        }

    }
}
