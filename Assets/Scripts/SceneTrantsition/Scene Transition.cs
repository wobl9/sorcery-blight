using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    private static SceneTransition _instance;

    private Animator _componentAnimator;
    private AsyncOperation _loadingSceneOperation;
    private static bool _shoulPlayOpeningAnimation = false;

    public static void SwitchToScene(string sceneName)
    {
        _instance._componentAnimator.SetTrigger("sceneClosing");
        _instance._loadingSceneOperation = SceneManager.LoadSceneAsync(sceneName);
        _instance._loadingSceneOperation.allowSceneActivation = false;
    }

    private void Start()
    {
        _instance = this;
        _componentAnimator = GetComponent<Animator>();
        
        if(_shoulPlayOpeningAnimation) _componentAnimator.SetTrigger("sceneOpening");
    }

    private void OnAnimationOver()
    {
        _shoulPlayOpeningAnimation = true;
        _loadingSceneOperation.allowSceneActivation = true;
    }
}