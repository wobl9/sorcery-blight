using Character;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class DungeonScene : MonoBehaviour
{
    private Dungeon _dungeon;
    private Room _currentRoom;
    private Player _player;
    
    [Inject]
    public void Construct(
        Player player,
        Dungeon dungeon
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
