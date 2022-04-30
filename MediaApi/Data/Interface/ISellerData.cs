using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface ISellerData
    {
        List<Seller> Get();

        Seller Get(Guid id);

        Seller Add(Seller i);

        Seller Update(Seller i);

        Boolean Delete(Guid id);
    }
}
