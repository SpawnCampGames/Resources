## First Person Mouse Look

### Setup

- Setup The Character (controller) as the root object. ( a capsule can be used to represent the player. )
- As a child of the character add a Camera. ( for simplicity orientate the camera the same direction as character and aligned where the eyes would be )

![image](https://github.com/SpawnCampGames/Resources/assets/60554748/8543d199-0d97-4091-b16d-e6a10b0ec650)

### Functionallity

In the code the easiest solution I have found is to rotate the player only on its Y axis (left and right)
This way the camera follows along and gets rotated left and right because it's attached to the player you're rotating
Then, we only rotate the camera on it's X axis (up and down)

![image](https://github.com/SpawnCampGames/Resources/assets/60554748/281dde95-c5d4-46ee-ac56-35d8c5d2f713)

This helps keep the rotational values seperate and prevents stuff like gimbal lock and having to implement a solution.

### Code

```cs
using UnityEngine;

  public class ControllerCamera : MonoBehaviour
    {
        public GameObject controller;
        [SerializeField] private float lookSensitivity = 1.5f;
        [SerializeField] public float speed;
        [SerializeField] private float smoothing = 1.5f;
        [SerializeField] private Vector2 smoothedVelocity;
        [SerializeField] private Vector2 currentLookingPos;

        public float playersYRotation;

        void Start()
        {
            LockCursors();
        }

        private void OnEnable()
        {
            currentLookingPos.x = controller.transform.eulerAngles.y;
        }

        void Update()
        {
            playersYRotation = controller.transform.eulerAngles.y;
            RotateCamera();
        }
        private void RotateCamera()
        {
            // get our input
            Vector2 inputValues = new Vector2(Input.GetAxisRaw("Mouse X"),Input.GetAxisRaw("Mouse Y"));
            inputValues = Vector2.Scale(inputValues,new Vector2(lookSensitivity * smoothing,lookSensitivity * smoothing));

            smoothedVelocity.x = Mathf.Lerp(smoothedVelocity.x,inputValues.x,1f / smoothing);
            smoothedVelocity.y = Mathf.Lerp(smoothedVelocity.y,inputValues.y,1f / smoothing);

            currentLookingPos += smoothedVelocity;

            // rotate the camera on it's X axis (up and down)
            transform.localRotation = Quaternion.AngleAxis(-currentLookingPos.y,Vector3.right);

            // rotate the player on it's Y axis (left and right)
            controller.transform.localRotation = Quaternion.AngleAxis(currentLookingPos.x,controller.transform.up);
        }

        private void LockCursors()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
```




