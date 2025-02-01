using UnityEngine;

public class ChildTransformController : MonoBehaviour
{
    private void Update()
    {
        // Rotate the target GameObject
        transform.Rotate(new Vector3(360, 360, 360) * Time.deltaTime);
    }
}
