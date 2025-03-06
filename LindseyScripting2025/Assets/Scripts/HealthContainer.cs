using UnityEngine;

public class HealthContainer : MonoBehaviour
{
 public SimpleFloatData healthData;

 public void ReduceHealth(float amount)
 {
  healthData.UpdateValue(amount);
 }

 public void IncreaseHealth(float amount)
 {
  healthData.UpdateValue(amount);
 }
}
