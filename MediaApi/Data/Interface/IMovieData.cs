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

        Movie UpdateMovie(Movie movie);

        Boolean DeleteMovie(Guid id);

    }
}
