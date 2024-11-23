using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 25f;
    void Update()
    {
        transform.rotation = Quaternion.Euler(0,transform.eulerAngles.y+rotationSpeed*Time.deltaTime,0);
    }
}
