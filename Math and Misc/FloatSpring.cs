using UnityEngine;

//SpawnCampGames.com

public class Spring : MonoBehaviour
{
    public float currentValue;  //value springs towards targetValue
    public float currentVelocity;
    public float targetValue = 1;
    public float stiffness = 100f;
    public float damping = 10f;
    public float valueThreshold = 0.01f;
    public float velocityThreshold = 0.01f;

    private void Start()
    {
        currentValue = targetValue;
    }

    void FixedUpdate()
    {
        float dampingFactor = Mathf.Max(0,1 - damping * Time.fixedDeltaTime);
        float acceleration = (targetValue - currentValue) * stiffness * Time.fixedDeltaTime;
        currentVelocity = currentVelocity * dampingFactor + acceleration;
        currentValue += currentVelocity * Time.fixedDeltaTime;

        if(Mathf.Abs(currentValue - targetValue) < valueThreshold && Mathf.Abs(currentVelocity) < velocityThreshold)
        {
            currentValue = targetValue;
            currentVelocity = 0f;
        }

        var pos = transform.position;
        pos.y = currentValue;
        transform.position = pos;
    }
}
