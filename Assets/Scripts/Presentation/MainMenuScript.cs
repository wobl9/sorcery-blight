using UnityEngine;
using UnityEngine.SceneManagement;
using utils.save;
using Zenject;

public class MainMenuScript : MonoBehaviour
{

    [SerializeField] protected GameObject continueButton;
    private ISaveSystem _saveSystem;

    [Inject]
    public void Construct(ISaveSystem saveSystem)
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
        SceneTransition.SwitchToScene("DungeonScene");
    }
}