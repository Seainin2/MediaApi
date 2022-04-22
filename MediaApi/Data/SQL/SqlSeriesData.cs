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

        public bool DeleteSeries(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Series> GetSeries()
        {
            return _allContext.Series.ToList();
        }

        public Series getSeries(Guid id)
        {

            Series series = _allContext.Series.Find(id);
            if (series == null) {
                return null;
            }
            List<Object> list = new List<object>();

            List<Movie> movies = _allContext.Movies.Where(x => x.SeriesId == id).ToList();
            if (movies.Any()) { list.AddRange(movies); }

            List<Book> books = _allContext.Books.Where(x => x.SeriesId == id).ToList();
            if (books.Any()) { list.AddRange(books); }

            List<Game> games = _allContext.Games.Where(x => x.SeriesId == id).ToList();
            if (games.Any()) { list.AddRange(games); }

            List<Show> shows = _allContext.Shows.Where(x => x.SeriesId == id).ToList();
            if (shows.Any())
            {


                foreach (Show show in shows)
                {


                    show.Seasons = _allContext.Seasons.Where(x => x.MediaId == show.MediaId).ToList();

                    foreach (Season season in show.Seasons)
                    {
                        season.Episodes = _allContext.Episodes.Where(x => x.SeasonId == season.SeasonId).ToList();
                    }


                }

                list.AddRange(shows);
            }

            series.Media = list;

            return series;


        }

        public Series UpdateSeries(Series series)
        {
            throw new NotImplementedException();
        }
    }
}
