using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data
{
    public interface ISeriesData
    {

        List<Series> GetSeries();

        Series getSeries(Guid id);

        Series AddSeries(Series series);

        Series UpdateSeries(Series series);

        Boolean DeleteSeries(Guid id);

    }
}
