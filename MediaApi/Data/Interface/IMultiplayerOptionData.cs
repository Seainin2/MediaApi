using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface IMultiplayerOptionData
    {
        List<MultiplayerOption> Get();

        MultiplayerOption Get(Guid id);

        MultiplayerOption Add(MultiplayerOption i);

        MultiplayerOption Update(MultiplayerOption i);

        Boolean Delete(Guid id);
    }
}
