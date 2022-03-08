using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data
{
    public interface IMovieData
    {

        List<Movie> GetMovies();

        Movie GetMovie(Guid id);

        Movie AddMovie(Movie movie);

        List<Movie> GetMoviesBySeriesId(Guid id);

        List<Movie> getMoviesByCreatingPropertyId(Guid id);

    }
}
