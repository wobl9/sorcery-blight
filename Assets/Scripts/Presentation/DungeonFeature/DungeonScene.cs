using System;
using Character;
using Dungeon;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class DungeonScene : MonoBehaviour
{
    private Dungeon.Dungeon _dungeon;
    private Room _currentRoom;
    private Player _player;
    
    [Inject]
    public void Construct(
        Player player,
        Dungeon.Dungeon dungeon
        )
    {
        _player = player;
        _dungeon = dungeon;
    }

    public void CreateCharacter()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
