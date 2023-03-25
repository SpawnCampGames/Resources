## Public Variable

One simple way to reference a gameobject in Unity is to create a public variable:
```
// public fields will be visible in the inspector
public Apple referenceToApple;
```

It can now be seen in the inspector view when the gameobject is selected.

and now any gameobject with an instance of `Apple` can simply be dragged and dropped into place.
now any public variable or function within the class can be called as an example

```
referenceToApple.BiteApple(); // or
referenceToApple.weightInGrams = 150;
```

However if other scripts don't need to access it you can use Serialize Field instead, to keep the field private and still visible to you.

```
// This will also be visible in the inspector
[SerializeField]
public Apple referenceToApple;
```
