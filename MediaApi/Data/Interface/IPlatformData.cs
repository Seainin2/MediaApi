using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface IPlatformData
    {
        List<Platform> Get();

        Platform Get(Guid id);

        Platform Add(Platform i);

        Platform Update(Platform i);

        Boolean Delete(Guid id);
    }
}
