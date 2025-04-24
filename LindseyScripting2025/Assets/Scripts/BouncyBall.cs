using UnityEngine;

public class BouncyBall : MonoBehaviour
{
  public float bounceForce = 100f;
  private void OnCollisionEnter(Collision collision)
  {
    GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
  }
}
