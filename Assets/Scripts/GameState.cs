using System;
using Character;

[Serializable]
public class GameState
{
    public readonly Dungeon Dungeon;
    public readonly Player Player;

    public GameState() {}

    public GameState(Player player, Dungeon dungeon)
    {
        Dungeon = dungeon;
        Player = player;
    }
}