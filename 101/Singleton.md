A singleton in Unity is a normal class that holds a *public static reference* to an **instance** of its own type.

```csharp
public class GameManager : MonoBehaviour 
{
    public static GameManager instance;
}
```

A static variable means that it is shared by all instances of the class
Any script can access the singleton through its class name, without needing a reference to it first.

```csharp
GameManager.instance;
```

*However, because any script can access it*, it’s generally a good idea to protect the instance variable with a property,
which simply means that it can be read by other scripts, but it can only be set from within its own class.

#### Singleton

```csharp
public class Singleton : MonoBehaviour 
{
    public static Singleton Instance { get; private set; }
}
```

While the *static reference* can only ever point to one instance of the script, it’s possible to have more than one instance of the singleton in the scene.
Which is why it’s important to make sure that there is only ever one instance of the singleton.

### 📌Basic Singleton
```csharp
public class GameManager: MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            // If theres already an instance and it isnt this one
            Destroy(this);
        }
        else
        {
            // If theres not an instance or this is already it
            Instance = this;
        }
    }
}

```

### Use-cases
Singletons can be very convenient because they allow you to connect parts of your game more easily.
For UI 🎥
```csharp
float healthBarValue = UserInterfaceManager.Instance.playerHealth;
```
For Audio 🔈
```csharp
AudioManager.Instance.PlaySound(clipToPlay);;
```
Great For ⚙️Game Manager type classes
```csharp
    // List of Public Variables
    public float totalPlaytime;
    public GameObject player;

    // List of Public Functions
    public void ResetPlayer()
    {
        player.transform.position = Vector3.zero;
        // reset level and taunt player
    }
```
then accessed from any class via calling `GameManager.Instance.`
```csharp
var floatToDisplay = GameManager.Instance.totalPlaytime;

if(playerSkill < developersSkillExpectation){
GameManager.Instance.ResetPlayer();
```

> There's downsides to a `Singleton` as well, check out the source cited below if you would like to know more.

Sources:
------
https://gamedevbeginner.com/singletons-in-unity-the-right-way/

https://gamedev.stackexchange.com/questions/116009/in-unity-how-do-i-correctly-implement-the-singleton-pattern

http://www.unitygeek.com/unity_c_singleton/

