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

            List<Movie> movies = _allContext.Movies.Where(x => x.SeriesId == id).ToList();
            List<Book> books = _allContext.Books.Where(x => x.SeriesId == id).ToList();
            List<Game> games = _allContext.Games.Where(x => x.SeriesId == id).ToList();
            List<Season> seasons = _allContext.Seasons.Where(x => x.SeriesId == id).ToList();

            list.AddRange(movies);
            list.AddRange(books);
            list.AddRange(games);
            list.AddRange(seasons);

            series.Media = list;

            return series;
        }
    }
}
