using System;
using System.Collections.Generic;
using DIO.Series;

namespace DIO.Series.Domain
{
    public class MovieRepository : IRepository<Movie>
    {
        private List<Movie> listMovies = new List<Movie>();
        public List<Movie> List() { throw new NotImplementedException(); }
        public Movie ReturnById(int id) { throw new NotImplementedException(); }
        public void Insert(Movie movie) { throw new NotImplementedException(); }
        public void Delete(int id) { throw new NotImplementedException(); }
        public void Update(int id, Movie movie) { throw new NotImplementedException(); }
        public int NexId() { throw new NotImplementedException(); }

    }
}