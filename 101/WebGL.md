# 📙 Unity WebGL Cheatsheet

### Features and APIs with Limitations in Unity WebGL

1. **Threading**
   - `Thread`
   - `Task`
   - `BackgroundWorker`

2. **File I/O**
   - `FileStream`
   - `StreamReader`
   - `StreamWriter`
   - General file system access

3. **System APIs**
   - `System.Diagnostics.Process`
   - `System.IO.Pipes`
   - Other OS-dependent APIs

4. **Networking**
   - `System.Net.Sockets`
   - Low-level socket operations

5. **Reflection.Emit**
   - `System.Reflection.Emit`
   - Dynamic code generation

6. **Platform-Specific APIs**
   - Native code plugins
   - Any platform-specific features

7. **Local Storage**
   - Traditional file-based persistent storage
   - Limited to browser-based storage solutions (e.g., PlayerPrefs)

8. **Audio APIs**
   - Some advanced audio features
   - Platform-specific audio handling differences

9. **Task.Delay**
   - Relies on threading, which is not supported

### 🔧 Alternative Solutions  
- **Delays and Timing**:
  - Use Unity's Coroutine system.  
```csharp
  using UnityEngine;
  using System.Collections;

  public class Example : MonoBehaviour
  {
      void Start()
      {
          StartCoroutine(DelayedAction());
      }

      IEnumerator DelayedAction()
      {
          // Wait for 2 seconds
          yield return new WaitForSeconds(2f);

          // Perform the action after the delay
          Debug.Log("Action performed after delay");
      }
  }
```
---

<p align="center"><sub>"Copyright SpawnCampGames 2024"</sub></p>
