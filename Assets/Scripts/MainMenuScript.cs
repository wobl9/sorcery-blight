using UnityEngine;
using UnityEngine.SceneManagement;
using utils.save;
using Zenject;

public class MainMenuScript : MonoBehaviour
{

    [SerializeField] protected GameObject continueButton;
    private SaveSystem _saveSystem;

    [Inject]
    public void Construct(SaveSystem saveSystem)
    {
        _saveSystem = saveSystem;
    }
    private void OnEnable()
    {
        var savedState = _saveSystem.Load();
        continueButton.SetActive(savedState != null);
    }

    public void CreateCharacter()
    {
        SceneManager.LoadScene("CreateCharacter");
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene("Game");
    }
}