
//using MovieAppDLL.Models;
using MovieAppDLL1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MovieAppDLL1.Services
{
    public class DataSerializer
    {

        public void Serializer(Movie movie)
        {
            string fileName = "Movies.json";
            List<Movie> movies = new List<Movie>();
            movies.Add(movie);
            string jsonString = JsonSerializer.Serialize(movies);
            File.WriteAllText(fileName, jsonString);
            //FileStream fileStream = new FileStream("Movies.txt", FileMode.Append, FileAccess.Write);
            //BinaryFormatter binaryforammatter = new BinaryFormatter();
            //binaryforammatter.Serialize(fileStream,movie);
            //fileStream.Close();
            Console.WriteLine("Serialization completed!");
        }

        public List<Movie> DeSerializer()
        {
            List<Movie> movies = new List<Movie>();
            string fileName = "Movies.json";
            string jsonString;
            if (File.Exists(fileName))
            {
                jsonString = File.ReadAllText(fileName);
                movies = JsonSerializer.Deserialize<List<Movie>>(jsonString);
            }
            return movies;

        }
    }
}
