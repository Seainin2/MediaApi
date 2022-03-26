using System;
using System.Collections.Generic;

namespace MediaApi.Data
{
    public interface IFeedData
    {

        List<object> GetMedia(List<String> mediaTypes, String search = "");

        List<object> GetAllMedia();

    }
}
