using MediaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaApi.Data
{
    public class SqlEpisodeData : IEpisodeData
    {

        private AllContext _allContext;

        public SqlEpisodeData(AllContext allContext)
        {
            _allContext = allContext;
        }
        public Episode AddEpisode(Episode episode)
        {
            _allContext.Episodes.Add(episode);
            _allContext.SaveChanges();
            return episode;
        }

        public bool DeleteEpisode(Guid id)
        {
            throw new NotImplementedException();
        }

        public Episode GetEpisode(Guid id)
        {
            return _allContext.Episodes.Find(id);
        }

        public List<Episode> GetEpisodes()
        {
            return _allContext.Episodes.ToList();
        }

        public List<Episode> GetEpisodesBySeasonId(Guid id)
        {
            return _allContext.Episodes.Where(x => x.SeasonId == id).ToList();
        }

        public Episode UpdateEpisode(Episode episode)
        {
            throw new NotImplementedException();
        }
    }
}
