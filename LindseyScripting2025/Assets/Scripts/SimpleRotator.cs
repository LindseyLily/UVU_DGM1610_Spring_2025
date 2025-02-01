using UnityEngine;

public class SimpleRotator : MonoBehaviour
{
    public float rotationSpeed = 3000f;
        void Update()
        {
            transform.Rotate(rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime);
        }
}
