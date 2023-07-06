using UnityEngine;
using utils.save;
using Zenject;

public class Settings : MonoBehaviour
{
    private ISaveSystem _saveSystem;

    [Inject]
    public void Construct(ISaveSystem saveSystem)
    {
        _saveSystem = saveSystem;
    }

    public void Reset()
    {
        _saveSystem.Clear();
    }
}