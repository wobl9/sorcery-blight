using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
    private SaveSystem _saveSystem;
    
    [Inject]
    public void Construct(SaveSystem saveSystem)
    {
        _saveSystem = saveSystem;
    }
    void Update()
    {
        startGameButton.enabled = !string.IsNullOrEmpty(inputField.text);
    }

    public void StartGame()
    {
        Player player = new Player(inputField.text);
        _saveSystem.Save(new SaveData(player));
        SceneManager.LoadScene("Game");
    }

    void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}