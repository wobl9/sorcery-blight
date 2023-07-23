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

    [Inject]
    public void Construct(ISaveSystem saveSystem)
    {
        _saveSystem = saveSystem;
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
        _saveSystem.Save(new SaveData(player));
        SceneManager.LoadScene("DungeonScene");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}