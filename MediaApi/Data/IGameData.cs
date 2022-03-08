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

        List<Game> GetGamesBySeriesId(Guid id);

        List<Game> getGamesByCreatingPropertyId(Guid id);

    }
}
