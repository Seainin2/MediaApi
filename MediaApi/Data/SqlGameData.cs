using MediaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MediaApi.Data
{
    public class SqlGameData : IGameData
    {

        private AllContext _allContext;

        public SqlGameData(AllContext allContext)
        {
            _allContext = allContext;
        }
        public Game AddGame(Game game)
        {
            _allContext.Games.Add(game);
            _allContext.SaveChanges();
            return game;
        }

        public Game GetGame(Guid id)
        {
            return _allContext.Games.Find(id);
        }

        public List<Game> GetGames()
        {
            return _allContext.Games.ToList();
        }

        public List<Game> getGamesByCreatingPropertyId(Guid id)
        {
            return _allContext.Games.Where(x => x.CreatingPropertyId == id).ToList();
        }

        public List<Game> GetGamesBySeriesId(Guid id)
        {
            return _allContext.Games.Where(x => x.SeriesId == id).ToList();
        }
    }
}
