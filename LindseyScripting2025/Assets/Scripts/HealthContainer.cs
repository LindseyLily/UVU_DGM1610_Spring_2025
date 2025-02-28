using UnityEngine;

public class HealthContainer : MonoBehaviour
{
 public SimpleFloatData healthData;

 public void ReduceHealth(float amount)
 {
  healthData.UpdateValue(amount);
 }
}
