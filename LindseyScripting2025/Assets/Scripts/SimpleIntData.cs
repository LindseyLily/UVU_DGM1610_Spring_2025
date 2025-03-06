using UnityEngine;

public class SimpleIntData : MonoBehaviour
{
    public int value;
    // Will link to the score text
    public SimpleTextMeshProBehaviour textMeshProBehaviour;

    public void UpdateValue(int amount)
    {
        value += amount;
        // Updates the UI value after it changes
        textMeshProBehaviour.UpdateWithIntData();
    }

    public void SetValue(int amount)
    {
        value = amount;
        //Updates the UI after the value is set
        textMeshProBehaviour.UpdateWithIntData();
    }
}