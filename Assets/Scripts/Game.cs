using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public void CreateCharacter()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
