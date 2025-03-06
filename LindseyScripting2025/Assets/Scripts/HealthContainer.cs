using UnityEngine;

public class HealthContainer : MonoBehaviour
{
 public SimpleFloatData healthData;

 private void Start()
 {
  //Resets HP to 1 when the game starts
  healthData.SetValue(1f);
 }
 
 public void ReduceHealth(float amount)
 {
  healthData.UpdateValue(amount);
 }

 public void IncreaseHealth(float amount)
 {
  healthData.UpdateValue(amount);
 }
}
