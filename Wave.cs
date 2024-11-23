using UnityEngine;

public class Wave : MonoBehaviour
{
    private float amplitude = 8f;
    private float frequencyFactor = 1f;
    private float startY;
    public float phaseOffset;

    private void Start()
    {
        startY = transform.position.y;
    }

    private void Update()
    {
        float newY = startY + amplitude * Mathf.Sin(Time.time * frequencyFactor + phaseOffset);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
