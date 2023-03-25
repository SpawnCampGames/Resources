![image](https://user-images.githubusercontent.com/60554748/227697561-d0f41683-cff9-43ef-beba-72f1014d5268.png)

## Raycast Overload Cheat Sheet

### Raycast using a **Layermask**

Params Used
- origin
- direction
- maxDistance
- layerMask
- queryTriggerInteraction

```cs
public static bool Raycast(Vector3 origin, Vector3 direction,
    float maxDistance = Mathf.Infinity, int layerMask = DefaultRaycastLayers,
    QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);
```
---

### Raycast with **RaycastHit hitInfo**

Params Used
- origin
- direction
- hitInfo
- maxDistance
- layerMask
- queryTriggerInteraction

```cs
public static bool Raycast(Vector3 origin, Vector3 direction,
    out RaycastHit hitInfo, float maxDistance,
    int layerMask, QueryTriggerInteraction queryTriggerInteraction);
```
---

### Raycast with a **Ray**

Params Used
- ray
- maxDistance
- layerMask
- queryTriggerInteraction

```cs
public static bool Raycast(Ray ray,
    float maxDistance = Mathf.Infinity, int layerMask = DefaultRaycastLayers,
    QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);
```
---

### Raycast with a **Ray & RaycastHit hitInfo**

Params Used
- ray
- hitInfo
- maxDistance
- layerMask
- queryTriggerInteraction

```cs
public static bool Raycast(Ray ray, out RaycastHit hitInfo,
    float maxDistance = Mathf.Infinity, int layerMask = DefaultRaycastLayers,
    QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);
```

#### Physics.Raycast()
bool, Returns true if the ray intersects with a Collider, otherwise false.
Casts a ray, from point origin, in direction direction, of length maxDistance, against all colliders in the Scene.
You may optionally provide a LayerMask, to filter out any Colliders you aren't interested in generating collisions with.

Specifying queryTriggerInteraction allows you to control whether or not Trigger colliders generate a hit, or whether to use the global Physics.queriesHitTriggers setting. Raycast overloads utilizing the `out RaycastHit` will have additional information about the hit.

<sub>
Source:</sub>

https://docs.unity3d.com/ScriptReference/Physics.Raycast.html

