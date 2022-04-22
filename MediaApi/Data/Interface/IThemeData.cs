using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface IThemeData
    {
        List<Theme> Get();

        Theme Get(Guid id);

        Theme Add(Theme i);

        Theme Update(Theme i);

        Boolean Delete(Guid id);
    }
}
