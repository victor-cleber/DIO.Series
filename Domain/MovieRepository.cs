using System;
using System.Collections.Generic;
using DIO.Series;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class MovieRepository : IRepository<Movie>
    {
        private List<Movie> listMovies = new List<Movie>();
        public List<Movie> List()
        {

            return listMovies;
        }
        public Movie ReturnById(int id)
        {
            return listMovies[id];
        }
        public void Insert(Movie movie)
        {
            listMovies.Add(movie);
        }
        public void Delete(int id)
        {
            //This method can be used but after removing,
            //the index will be reorganised (LGPD)
            //listMovies.RemoveAt(id);
            listMovies[id].Remove();
        }
        public void Update(int id, Movie movie)
        {
            listMovies[id] = movie;
        }
        public int NextId()
        {
            return listMovies.Count;
        }

    }
}