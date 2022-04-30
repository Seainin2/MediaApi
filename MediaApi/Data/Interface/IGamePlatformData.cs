using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface IGamePlatformData
    {
        List<GamePlatform> GetGamePlatform();

        GamePlatform GetGamePlatform(Guid id);

        GamePlatform AddGamePlatform(GamePlatform GamePlatform);

        GamePlatform UpdateGamePlatform(GamePlatform GamePlatform);

        Boolean DeleteGamePlatform(Guid id);
    }
}
