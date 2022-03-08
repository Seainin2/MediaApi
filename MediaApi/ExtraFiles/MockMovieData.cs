using MediaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaApi.Data
{
    public class MockMovieData : IMovieData
    {

        private List<Movie> movies = new List<Movie>() {
            new Movie(){

                MediaId = Guid.NewGuid(),
                Title = "Dune",
                ReleaseDate = "",
                Description = "A Sc-Fi Thriller about a young boy on his journey to become a god",
                Length = 183

            },
            new Movie(){

                MediaId = Guid.NewGuid(),
                Title = "Batman",
                ReleaseDate = "",
                Description = "Bruce wayne becomes the hero batman to fight crime in gothom",
                Length = 120

            }
        };

        public Movie AddMovie(Movie movie)
        {
            movie.MediaId = Guid.NewGuid();

            movies.Add(movie);

            return movie;
        }

        public Movie GetMovie(Guid id)
        {
            return movies.SingleOrDefault(x => x.MediaId == id);
        }

        public List<Movie> GetMovies()
        {
            return movies;
        }

        public List<Movie> getMoviesByCreatingPropertyId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetMoviesBySeriesId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
