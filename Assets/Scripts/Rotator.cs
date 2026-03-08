using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate (new Vector3 (1, 1, 180) * Time.deltaTime);
    }
}
