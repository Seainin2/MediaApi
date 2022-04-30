using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface IReccomendingResourceData
    {
        List<ReccomendingResource> Get();

        ReccomendingResource Get(Guid id);

        ReccomendingResource Add(ReccomendingResource i);

        ReccomendingResource Update(ReccomendingResource i);

        Boolean Delete(Guid id);
    }
}
