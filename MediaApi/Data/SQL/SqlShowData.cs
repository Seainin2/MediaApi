using MediaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaApi.Data
{
    public class SqlShowData : IShowData
    {
        private AllContext _allContext;

        public SqlShowData(AllContext allContext)
        {
            _allContext = allContext;
        }
        public Show AddShow(Show show)
        {
            _allContext.Shows.Add(show);
            _allContext.SaveChanges();
            return show;
        }

        public bool DeleteShow(Guid id)
        {
            throw new NotImplementedException();
        }

        public Show GetShow(Guid id)
        {
            Show show = _allContext.Shows.Find(id);
            if (show != null)
            {
                show.Seasons.AddRange(_allContext.Seasons.Where(x => x.MediaId == id).ToList());
                //List<Season> seasons = _allContext.Seasons.Where(x => x.MediaId == id).ToList();
                foreach (Season season in show.Seasons)
                {
                    season.Episodes.AddRange(_allContext.Episodes.Where(x => x.SeasonId == id).ToList());
                }
            }


            return show;
        }

        public List<Show> GetShows()
        {
            List<Show> shows = _allContext.Shows.ToList();
            foreach (Show show in shows)
            {
                show.Seasons = _allContext.Seasons.Where(x => x.MediaId == show.MediaId).ToList();

            }


            return shows;
        }

        public Show UpdateShow(Show show)
        {
            throw new NotImplementedException();
        }
    }
}
