#### A Generic Singleton Implementation

```csharp
public abstract class Singleton<T> : MonoBehaviour
where T : Singleton<T>
{
    public static T Instance { get; private set; }

    void Awake()
    {
        // Destroy this object if we already have a Singleton defined
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        Instance = (T)this;
        DoAwake();
    }

    // Virtual method to allow implementations to use Awake
    protected virtual void DoAwake() { }
}
```

then if you wan't to create a singleton, a `GameManager.cs` for example
```csharp
using UnityEngine;
public class GameManager: Singleton<GameManager>
{
    public void Start()
    {
        Debug.Log("Check");
    }
}
```

#### Classic Singleton
https://github.com/SpawnCampGames/Resources/edit/main/101/Singleton.md

#### Back to 1️⃣0️⃣1️⃣
https://github.com/SpawnCampGames/Resources/tree/main/101

