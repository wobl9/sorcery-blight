using UnityEngine;
using utils.save;
using Zenject;

public class Settings : MonoBehaviour
{
    private SaveSystem _saveSystem;

    [Inject]
    public void Construct(SaveSystem saveSystem)
    {
        _saveSystem = saveSystem;
    }

    public void Reset()
    {
        _saveSystem.Clear();
    }
}