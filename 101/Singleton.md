A singleton in Unity is a normal class that can be added to an in-game object.
What’s different about a singleton, however, is that the class holds a public static reference to an instance of its own type.

```csharp
public class GameManager : MonoBehaviour 
{
    public static GameManager instance;
}
```

The static reference is what makes a singleton globally accessible.
Making a variable static means that it is shared by all instances of the class, meaning that any script can access the singleton through its class name, without needing a reference to it first.

```csharp
GameManager.instance;
```

This means that any public methods or variables that exist in the singleton class can be accessed by other scripts in the game easily.
However, because any script can access it, it’s generally a good idea to protect the instance variable with a property, which simply means that it can be read by other scripts, but it can only be set from within its own class.

### Basic Singleton

```csharp
public class Singleton : MonoBehaviour 
{
    public static Singleton Instance { get; private set; }
}
```

While the reference to the script is static, meaning that it is the same in any and all instances of the class, the instance that it points to is not.
Meaning that, while the reference can only ever point to one instance of the script, it’s possible to have more than one instance of the singleton in the scene.
Which is why it’s important to make sure that there is only ever one instance of the singleton by checking to see if the static reference, if there is one, matches the script instance.
Then, if it doesn’t match, the script knows that it’s a duplicate and it can delete itself.

⭐
```csharp
using UnityEngine;
public class GameManager: MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
}

```

### Usecase
Singletons can be very convenient because they allow you to connect parts of your game more easily.
For UI 🎥
```csharp
float healthBarValue = UserInterfaceManager.Instance.playerHealth;
```
For Audio 🔈
```csharp
AudioManager.Instance.PlaySound(clipToPlay);;
```
Great For Game Manager ⚙️ type classes
```csharp
    //List of Public Variables
    public float totalPlaytime;

    //List of Public Functions
    public void ResetPlayer()
    {
        // reset player
        // reset level
        // taunt player
    }
```
then accessed simply as,
```csharp
var floatToDisplay = GameManager.Instance.totalPlaytime;

if(playerSkill < developersSkillExpectation){
GameManager.Instance.ResetPlayer();
```

> There's downsides to a `Singleton` as well, check out the source cited below if you would like to know more.

Sources:
------
https://gamedevbeginner.com/singletons-in-unity-the-right-way/
