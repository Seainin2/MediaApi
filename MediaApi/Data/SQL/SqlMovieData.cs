using MediaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaApi.Data
{
    public class SqlMovieData : IMovieData
    {

        private AllContext _allContext;

        public SqlMovieData(AllContext allContext) 
        {
            _allContext = allContext;
        }
        public Movie AddMovie(Movie movie)
        {
            _allContext.Movies.Add(movie);
            _allContext.SaveChanges();
            return movie;
        }

        public bool DeleteMovie(Guid id)
        {
            throw new NotImplementedException();
        }

        public Movie GetMovie(Guid id)
        {
            return _allContext.Movies.Find(id);
        }

        public List<Movie> GetMovies()
        {
            return _allContext.Movies.ToList();
        }

        public Movie UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
