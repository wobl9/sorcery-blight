using System;
using Character;

[Serializable]
public class GameState
{
    public Dungeon Dungeon
    {
        get;
        private set;
    }

    public Player Player
    {
        get;
        private set;
    }

    public GameState() {}

    public GameState(Player player, Dungeon dungeon)
    {
        Dungeon = dungeon;
        Player = player;
    }

    public void update(Player player, Dungeon dungeon)
    {
        Player = player;
        Dungeon = dungeon;
    }
}