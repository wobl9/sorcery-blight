using Character;
using Presentation.DungeonFeature;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;

public class DungeonScene : MonoBehaviour, IDungeonScene
{
    public Image PlayerImage;
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

    public void RenderPlayerImage(string path)
    {
        PlayerImage.sprite = Resources.Load<Sprite>(path);
    }

    public void CreateCharacter()
    {
        SceneManager.LoadScene("MainMenu");
    }
}