using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data
{
    public interface IGameData
    {
        List<Game> GetGames();

        Game GetGame(Guid id);

        Game AddGame(Game game);

        Game UpdateGame(Game game);

        Boolean DeleteGame(Guid id);

    }
}
