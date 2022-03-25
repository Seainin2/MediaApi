using System;
using System.Collections.Generic;

namespace MediaApi.Data
{
    public interface IFeedData
    {

        List<object> GetAllMedia(List<String> mediaTypes, String search = "");

    }
}
