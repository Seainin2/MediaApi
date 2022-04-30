using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface IGameMultiplayerOptionData
    {
        List<GameMultiplayerOption> GetGameMultiplayerOptions();

        GameMultiplayerOption GetGameMultiplayerOption(Guid id);

        GameMultiplayerOption AddGameMultiplayerOption(GameMultiplayerOption GameMultiplayerOption);

        GameMultiplayerOption UpdateGameMultiplayerOption(GameMultiplayerOption GameMultiplayerOption);

        Boolean DeleteGameMultiplayerOption(Guid id);
    }
}
