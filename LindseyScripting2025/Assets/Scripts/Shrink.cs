using UnityEngine;

public class Shrink : MonoBehaviour
{
  public float shrinkFactor = 0.5f;
  
  void OnCollisionEnter(Collision collision) 
  {
      transform.localScale *= shrinkFactor;
    }
}
