using UnityEngine;
using UnityEngine.UI;  // Needed for Image UI component

public class UIAnimationCollect : MonoBehaviour
{
    public Animator uiImageAnimator;  // Animator of the UI Image
    public SimpleIntData simpleIntData;  // Reference to SimpleIntData to track the value
    private int previousValue;  // To track the previous value and detect changes

    void Start()
    {
        // Initialize the previousValue with the current value from SimpleIntData
        if (simpleIntData != null)
        {
            previousValue = simpleIntData.value;
        }
    }

    // This method can be triggered to check if the value has increased
    public void SimpleTriggerEvent()
    {
        if (simpleIntData != null && uiImageAnimator != null)
        {
            // Check if the value has increased
            if (simpleIntData.value > previousValue)
            {
                // Trigger animation on the UI image
                uiImageAnimator.SetTrigger("MelonCollected");

                // Update previousValue to the current value
                previousValue = simpleIntData.value;
            }
        }
    }
}