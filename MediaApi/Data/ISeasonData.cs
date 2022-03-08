using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data
{
    public interface ISeasonData
    {

        List<Season> GetSeasons();

        Season GetSeason(Guid id);

        Season AddSeason(Season season);

        List<Season> GetSeasonsBySeriesId(Guid id);

        List<Season> GetSeasonsByCreatingPropertyId(Guid id);

    }
}
