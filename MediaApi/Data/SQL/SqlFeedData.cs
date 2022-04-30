using MediaApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace MediaApi.Data
{
    public class SqlFeedData : IFeedData
    {
        private AllContext _allContext;

        public SqlFeedData(AllContext allContext)
        {
            _allContext = allContext;
        }

        public List<object> GetAllMedia()
        {
            List<object> list = new List<object>();

            list.AddRange(_allContext.Movies.ToList());
            list.AddRange(_allContext.Books.ToList());
            list.AddRange(_allContext.Games.ToList());
            List<Show> shows = _allContext.Shows.ToList();
            foreach (Show show in shows)
            {
                show.Seasons = _allContext.Seasons.Where(x => x.MediaId == show.MediaId).ToList();
            }

            list.AddRange(shows);

            return list;
        
        }
        public List<object> GetMedia(List<string> mediaTypes,string title = "")
        {

            List<object> list = new List<object>();

            if(mediaTypes.Contains("Movies")) 
            {
                list.AddRange(_allContext.Movies.Where(x => x.Title.Contains(title)).ToList());
            }

            if(mediaTypes.Contains("Books")) 
            {
                list.AddRange(_allContext.Books.Where(x => x.Title.Contains(title)).ToList());
            }

            if (mediaTypes.Contains("Games")) 
            {
                list.AddRange(_allContext.Games.Where(x => x.Title.Contains(title)).ToList());
            }

            if (mediaTypes.Contains("Shows")) 
            {
                List<Show> shows = _allContext.Shows.Where(x => x.Title.Contains(title)).ToList();
                foreach (Show show in shows)
                {
                    show.Seasons = _allContext.Seasons.Where(x => x.MediaId == show.MediaId).ToList();
                }
                list.AddRange(shows);
            }

            return list;
        }
    }
}
