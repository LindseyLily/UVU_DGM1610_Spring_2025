using UnityEngine;

public class ChildTransformController : MonoBehaviour
{
    private void Update()
    {
        // Rotate the target GameObject
        transform.Rotate(new Vector3(0, 360, 0) * Time.deltaTime);
    }
}
