![Unity 101 Docs](https://github.com/SpawnCampGames/Resources/blob/main/101/img/Unity101.png)

# 📋 Unity 101 F.A.Q.s

### How to Convert Materials to URP 🎨
- Change the shader to a URP shader.
- Create new URP materials.
- Use the Material Upgrade Wizard: `Window > Rendering > Materials`.

---

### **The Three Commandments of `Awake` and `Start`**
- **Awake (<- Me):** Initialize internal components and variables (self-sufficiency).
- **Start (-> Them):** Interact with external objects or systems (dependencies).
- **Timing:** Never assume another object's `Start` has run in your `Awake`.

---

### **The Three Commandments of `OnTrigger` and `OnCollision`**
1. **Both items need a Collider** for the interaction to register.
2. **At least one item must have a Rigidbody** to enable physics-based interactions.
3. **Correct Collider Setup:** Ensure the appropriate Trigger or Collision settings (`isTrigger` checkbox) are configured based on your desired behavior.

---

#### [Back](https://github.com/SpawnCampGames/Resources/blob/master/readme.md) to 📚 Resources 
🧰 [The-Kit](https://github.com/spawncampgames/The-Kit/blob/master/readme.md) (SpawnCampGame's official Unity sandbox project.)  

📘 [SpawnCampGames Resources](https://github.com/SpawnCampGames/Resources/blob/master/readme.md) (Big Collection of Unity Related Resources and Github Repos all Unity/ GameDev Related)  

🗃️ [Useful-Scripts / Script Vault](https://github.com/SpawnCampGames/Useful-Scripts/blob/master/readme.md) (Collection of scripts useful for learning and / or prototyping)  

📄 [SpawnCampGames Gist Library](https://gist.github.com/spawncampgames) (Scripts Indexed in *Useful-Scripts*)  

👤 [About Unity Cheatsheet](https://github.com/SpawnCampGames/Resources/blob/master/101/About.md)  Discover more about Unity 101 Cheatsheet and it's curator.

---

<p align="center"><sub>"Copyright SpawnCampGames 2024"</sub></p>
