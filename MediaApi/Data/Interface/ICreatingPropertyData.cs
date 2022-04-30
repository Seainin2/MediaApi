using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface ICreatingPropertyData
    {
        List<CreatingProperty> GetCreatingPropertys();

        CreatingProperty GetCreatingProperty(Guid id);

        CreatingProperty AddCreatingProperty(CreatingProperty CreatingPropertyk);

        CreatingProperty UpdateCreatingProperty(CreatingProperty CreatingProperty);

        Boolean DeleteCreatingProperty(Guid id);
    }
}
