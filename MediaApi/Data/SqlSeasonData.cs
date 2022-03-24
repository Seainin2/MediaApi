using MediaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaApi.Data
{
    public class SqlSeasonData : ISeasonData
    {
        private AllContext _allContext;

        public SqlSeasonData(AllContext allContext)
        {
            _allContext = allContext;
        }
        public Season AddSeason(Season season)
        {
            _allContext.Seasons.Add(season);
            _allContext.SaveChanges();
            return season;
        }

        public Season GetSeason(Guid id)
        {
            Season season = _allContext.Seasons.Find(id);
            List<Episode> list = _allContext.Episodes.Where(x => x.SeasonId == id).ToList();
            if (list != null) {
                season.Episodes = list;
            }
            
            return season;
        }

        public List<Season> GetSeasons()
        {
            return _allContext.Seasons.ToList();
        }
    }
}
