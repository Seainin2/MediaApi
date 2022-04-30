using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface IPersonData
    {
        List<Person> Get();

        Person Get(Guid id);

        Person Add(Person i);

        Person Update(Person i);

        Boolean Delete(Guid id);
    }
}
