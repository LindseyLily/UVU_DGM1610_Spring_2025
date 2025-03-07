using UnityEngine;

public class HealingItem : MonoBehaviour
{
    private Animator animator;
    public UIAnimationCollect uiAnimationCollect;  // Reference to the UIAnimationCollect script

    void Start()
    {
        // Animator attached to the item
        animator = GetComponent<Animator>();
    }

    // Trigger collision with player
    private void OnTriggerEnter(Collider other)
    {
        // Trigger "PickUp" animation on the HealingItem
        if (animator != null)
        {
            animator.SetTrigger("PickUp");
        }

        // Trigger the animation on the UIImage (if the reference to UIAnimationCollect is assigned)
        if (uiAnimationCollect != null)
        {
            uiAnimationCollect.SimpleTriggerEvent();  // Trigger the UI animation event
        }

        // Destroy the healing item after the animation (delay to match animation length)
        Destroy(gameObject, 1f);
    }
}