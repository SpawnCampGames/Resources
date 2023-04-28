# Unity Raycasts 101
![image](https://user-images.githubusercontent.com/60554748/235270798-25cd5118-3129-4de4-8173-d966b7521e76.png)


- `bool Physics.Raycast()` -> *requires* Collider Components to hit.
- `bool Physics2D.Raycast()` -> *requires* Collider2D Component to hit.

#### 🔶 Example in 3D ➡
```cs
        public Transform raycastStart; // gameobject in scene representing raycast start point
        public float distance; // of the ray
        public LayerMask shootableLayer; // layermask with all layers wished to be detected enabled
        
        private Transform goHit; // a cached reference of last gameobject hit by raycast
        private Vector3 hitPos; // "      "       "        "       hit position of raycast

        private void Update()
        {
            // on left mouse click
            if(Input.GetMouseButtonDown(0))
            {
                // if raycast hits any collider using a layer defined in layermask along its direction within distance
                if(Physics.Raycast(raycastStart.position, raycastStart.forward, out hit, distance, shootableLayer))
                {
                    // Execute
                    Debug.Log("We hit: " + hit.transform.name);
                    hitPos = hit.point;
                    goHit = hit.transform.gameObject;
                }
            }
        }
```
![image](https://user-images.githubusercontent.com/60554748/235264495-d3534595-10b1-4355-991c-b573db2e70e1.png)


Raycasts come in many flavors. The one above makes use of the `RaycastHit` `out` variable to get useful information, about the transform *and/ or* any other component attached via the `GetComponent()` function.
Of course, that doesn't mean you have to use all of them. In the next example we don't have a LayerMask for example so after our raycast hits something we can do additional checks using the `hit` variable as before.

#### Checking hit 💢 variable
```cs
                if(Physics.Raycast(raycastStart.position, raycastStart.forward, out hit, distance))
                {
                    // no layermask. could run if raycast hits *any* collider
                    // maybe do additional checks using the `hit` variable
                    
                    if(hit.transform.CompareTag("Blue")
                    {
                        // Raycast hit a collider tagged with Blue
                    }
                }
```

this code would run anytime the raycast intersects a collider tagged with the `Blue` tag.

![image](https://user-images.githubusercontent.com/60554748/235266950-3bc792b5-3345-458b-a9bc-ffb1aa057b35.png)

*Spelling is very important*.. , make sure theres there's no misspellings or extra characters and that you're `CompareTag("")` includes it's quotation marks `""`.
For example `blue` would compare as false. 

### 📚 Technical Stuff

#### Other strains of the Raycast

```cs
    RaycastHit[] RaycastAll() // Casts a ray through the scene and stores all the hits to an array of RaycastHit.
    
    int RaycastNonAlloc() // Casts a ray through the scene and stores the hits into the buffer.
                          // Like Physics.RaycastAll, but generates no garbage. The raycast query ends when there are no
                          // more hits and/or the results buffer is full. 
```

#### 🔶 RaycastAll()
```cs
      RaycastHit[] raycastAllHits;
      raycastAllHits = Physics.RaycastAll(raycastStart.position, raycastStart.forward, distance, shootableLayer);
      Debug.Log("We hit " + raycastAllHits.length + " colliders");
      
      // for example if we only ever wanted to cache 5 hits
      RaycastHit[] raycastNonAllocHits = new RaycastHit[5];
  ```
  #### 🔶 RaycastNonAlloc()
  ```cs    
      int hits = Physics.RaycastNonAlloc(raycastStart.position, raycastStart.forward, raycastNonAllocHits, distance, shootableLayer);
      for (int i = 0; i < hits; i++)
      {
          Debug.Log("Hit " + raycastNonAllocHits[i].collider.gameObject.name);
      }
      if (hits == 0)
      {
          Debug.Log("Did not hit");
      }
```

## 🌠 Raycast Overload Cheat Sheet

### **Layermask**

Params Used
- origin
- direction
- maxDistance
- layerMask
- queryTriggerInteraction

```cs
    public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = Mathf.Infinity,
    int layerMask = DefaultRaycastLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);
```
---

### **RaycastHit hitInfo**

Params Used
- origin
- direction
- hitInfo
- maxDistance
- layerMask
- queryTriggerInteraction

```cs
    public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance,
    int layerMask, QueryTriggerInteraction queryTriggerInteraction);
```
---

### **Ray**

Params Used
- ray
- maxDistance
- layerMask
- queryTriggerInteraction

```cs
    public static bool Raycast(Ray ray, float maxDistance = Mathf.Infinity, int layerMask = DefaultRaycastLayers,
    QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);
```
---

### **Ray & RaycastHit hitInfo**

Params Used
- ray
- hitInfo
- maxDistance
- layerMask
- queryTriggerInteraction

```cs
    public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance = Mathf.Infinity, 
    int layerMask = DefaultRaycastLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);
```
---
### 🔶 Physics.Raycast()
bool, Returns true if the ray intersects with a Collider, otherwise false.
Casts a ray, from point origin, in direction direction, of length maxDistance, against all colliders in the Scene.
You may optionally provide a LayerMask, to filter out any Colliders you aren't interested in generating collisions with.

Specifying queryTriggerInteraction allows you to control whether or not Trigger colliders generate a hit, or whether to use the global Physics.queriesHitTriggers setting. Raycast overloads utilizing the `out RaycastHit` will have additional information about the hit.

<sub>
Source:</sub> 📋

https://docs.unity3d.com/ScriptReference/Physics.Raycast.html 

