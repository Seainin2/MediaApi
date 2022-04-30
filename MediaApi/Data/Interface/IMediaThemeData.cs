using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface IMediaThemeData
    {
        List<MediaTheme> Get();

        MediaTheme Get(Guid id);

        MediaTheme Add(MediaTheme i);

        MediaTheme Update(MediaTheme i);

        Boolean Delete(Guid id);
    }
}
