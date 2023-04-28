## 🏷️Public Variable

One simple way to reference a gameobject in Unity is to create a public variable:
```cs
public Apple referenceToApple;
```


Now the public field is visible in the inspector.

![image](https://user-images.githubusercontent.com/60554748/227689118-08cd874d-9334-42e9-ae63-d584b7d4a7d0.png)

Any gameobject with an instance of the `Apple` class can simply be dragged and dropped into place.

![public variable](https://user-images.githubusercontent.com/60554748/227689794-0f5b9380-7db1-4a99-91c5-0644e45e8cf3.gif)

and..

```cs
referenceToApple.BiteApple(); // or
referenceToApple.weightInGrams = 150;
```

⭐However if other scripts don't need to access it you can use Serialize Field instead, to keep the field private and still visible to you.

```cs
// This will also be visible in the inspector
[SerializeField]
public Apple referenceToApple;
```
