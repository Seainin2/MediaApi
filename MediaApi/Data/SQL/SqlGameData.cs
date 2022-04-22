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

        public bool DeleteGame(Guid id)
        {
            throw new NotImplementedException();
        }

        public Game GetGame(Guid id)
        {
            return _allContext.Games.Find(id);
        }

        public List<Game> GetGames()
        {
            return _allContext.Games.ToList();
        }

        public Game UpdateGame(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
