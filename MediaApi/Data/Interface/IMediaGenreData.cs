using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface IMediaGenreData
    {
        List<MediaGenre> GetMediaGenre();

        MediaGenre GetMediaGenre(Guid id);

        MediaGenre AddMediaGenre(MediaGenre MediaGenre);

        MediaGenre UpdateMediaGenre(MediaGenre MediaGenre);

        Boolean DeleteMediaGenre(Guid id);
    }
}

