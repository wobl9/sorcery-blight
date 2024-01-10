using Character;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using utils.save;
using Zenject;

public class CreateCharacter : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button startGameButton;
    private ISaveSystem _saveSystem;
    private DungeonFactory _dungeonFactory;
    private GameState _gameState;

    [Inject]
    public void Construct(ISaveSystem saveSystem, GameState gameState, DungeonFactory dungeonFactory)
    {
        _gameState = gameState;
        _saveSystem = saveSystem;
        _dungeonFactory = dungeonFactory;
    }

    void Update()
    {
        startGameButton.enabled = !string.IsNullOrEmpty(inputField.text);
    }

    public void StartGame()
    {
        Player player = new Player(
            name: inputField.text,
            strength: 5,
            maxHp: 100,
            hp: 100,
            defense: 2,
            experience: 0
        );
        _gameState.update(player, _dungeonFactory.GenerateDungeon());
        _saveSystem.Save(new SaveData(_gameState));
        SceneTransition.SwitchToScene("DungeonScene");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}