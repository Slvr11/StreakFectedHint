using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using InfinityScript;

public unsafe class SFHint : BaseScript
{
    public int CPOffset = 0x64813AF;
    public SFHint()
    {
        *(int*)CPOffset = 0x16;
        PlayerConnected += CustomWeapon_PlayerConnected;
    }

    void CustomWeapon_PlayerConnected(Entity obj)
    {
        obj.SpawnedPlayer += () => OnPlayerSpawned(obj);
    }
    public void OnPlayerSpawned(Entity player)
    {
        if (player.IsAlive && player.SessionTeam == "axis")
        {
            player.IPrintLnBold("^2Get kills using Martyrdom!");
        }
    }
}

