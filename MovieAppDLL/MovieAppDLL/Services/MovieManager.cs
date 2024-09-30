
using MovieAppDLL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace MovieAppDLL.Services
{
    public class MovieManager
    {
        List<Movie> movies;
        int count;
        DataSerializer serializer;

        public MovieManager() {
            //movies= new List<Movie>();
            movies = serializer.DeSerializer();
            count = 0;
            
        }
        public void AddMovie(Movie movie)  {
            
                if (count <= 5)
                {
                    movies.Add(movie);
                    count++;
                    serializer.Serializer(movie);
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
