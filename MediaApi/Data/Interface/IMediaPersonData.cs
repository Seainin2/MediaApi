using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface IMediaPersonData
    {
        List<MediaPerson> Get();

        MediaPerson Get(Guid id);

        MediaPerson Add(MediaPerson MediaPerson);

        MediaPerson Update(MediaPerson MediaPerson);

        Boolean Delete(Guid id);
    }
}
//List<> Get();

//Get(Guid id);

//Add(i i);

//Update(i i);

//Boolean Delete(Guid id);