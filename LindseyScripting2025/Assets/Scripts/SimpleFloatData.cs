using UnityEngine;

[CreateAssetMenu(fileName = "SimpleFloatData", menuName = "Scriptable Objects/SimpleFloatData")]
public class SimpleFloatData : ScriptableObject
{
   public float value;

   public void UpdateValue(float amount)
   {
      value += amount;
   }

   public void SetValue(float amount)
   {
      value = amount;
   }
}
