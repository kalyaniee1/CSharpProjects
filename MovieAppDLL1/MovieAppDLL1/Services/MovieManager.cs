
//using MovieAppDLL.Models;
using MovieAppDLL1.Models;
using System.Collections.Generic;

namespace MovieAppDLL1.Services
{
    public class MovieManager
    {
        List<Movie> movies;
        int count;
        DataSerializer dataSerializer = new DataSerializer();

        public MovieManager() {
            //movies= new List<Movie>();
            count = 0;
            movies = dataSerializer.DeSerializer();
        }
        public void AddMovie(Movie movie)  {
            
                if (count <= 5)
                {
                    movies.Add(movie);
                    count++;
                dataSerializer.Serializer(movie);
                }
                else {
                    throw new Exceptions.ListFullException("Could not add the movie. The list is full");
                }
            

        }
        public List<Movie> ReadMovie() {
                if (movies!=null)
                {
                    return movies;
                }
                else
                {
                throw new Exceptions.ListEmptyException("Movie store empty");
                }          
        }
        public void RemoveMovie(string ID) {
            if (movies.Count > 0)
            {
                for(int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].Id==ID)
                        movies.RemoveAt(i);
                }
            }
        }

    }
    }
