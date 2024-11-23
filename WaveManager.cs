using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public Transform parent;
    public float offsetIncrement = Mathf.PI / 8;

    private void Start()
    {
        float currentOffset = 0f;

        foreach (Transform child in parent)
        {
            Wave wave = child.GetComponent<Wave>();
            if (wave != null)
            {
                wave.phaseOffset = currentOffset;
                currentOffset += offsetIncrement;
            }
        }
    }
}
