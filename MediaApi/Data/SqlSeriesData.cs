using MediaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace MediaApi.Data
{
    public class SqlSeriesData : ISeriesData
    {

        private AllContext _allContext;

        public SqlSeriesData(AllContext allContext)
        {
            _allContext = allContext;
        }
        public Series AddSeries(Series series)
        {
            _allContext.Series.Add(series);
            _allContext.SaveChanges();
            return series;
        }

        public List<Series> GetSeries()
        {
            return _allContext.Series.ToList();
        }

        public Series getSeries(Guid id)
        {
            Series series = _allContext.Series.Find(id);
            List<Object> list = new List<Object>();

            list.AddRange(_allContext.Movies.Where(x => x.SeriesId == id).ToList());

            list.AddRange(_allContext.Books.Where(x => x.SeriesId == id).ToList());

            list.AddRange(_allContext.Games.Where(x => x.SeriesId == id).ToList());

            List<Show> shows = _allContext.Shows.Where(x => x.SeriesId == id).ToList();
            foreach(Show show in shows) {
                
                
                show.Seasons = _allContext.Seasons.Where(x => x.MediaId == show.MediaId).ToList();

                foreach (Season season in show.Seasons)
                {
                    season.Episodes = _allContext.Episodes.Where(x => x.SeasonId == season.SeasonId).ToList();
                }
                
                
            }

            list.AddRange(shows);

            series.Media = list;

            return series;
        }
    }
}
