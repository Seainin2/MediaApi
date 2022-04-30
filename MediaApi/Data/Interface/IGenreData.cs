using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface IGenreData
    {
        List<Genre> GetGenre();

        Genre GetGenre(Guid id);

        Genre AddGenre(Genre Genre);

        Genre UpdateGenre(Genre Genre);

        Boolean DeleteGenre(Guid id);
    }
}
