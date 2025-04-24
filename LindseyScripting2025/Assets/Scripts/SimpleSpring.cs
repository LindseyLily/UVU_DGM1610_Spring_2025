
using UnityEngine;

public class SimpleSpring
    : MonoBehaviour
{
    [Header("Trampoline Jump Variables")]
    [SerializeField] private float springJumpForce = 15f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SimpleCharacterController controller = other.GetComponent<SimpleCharacterController>();
            if (controller != null)
            {
                controller.BounceFromSpring(springJumpForce);
            }
        }
    }
}
