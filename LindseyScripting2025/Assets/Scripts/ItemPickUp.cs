using UnityEngine;
using UnityEngine.UI; // To access UI elements

public class ItemPickup : MonoBehaviour
{
    public Image itemIcon; //Image
    public string itemTag = "Player"; // Identifies player
    private bool itemPickedUp = false; // The item being picked up

    void Start()
    {
        // Hides the image until triggered
        if (itemIcon != null)
        {
            itemIcon.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Objects are colliding
        if (other.CompareTag(itemTag) && !itemPickedUp)
        {
            // The player picked up the item
            itemPickedUp = true;

            // The image shows
            if (itemIcon != null)
            {
                itemIcon.enabled = true;
            }
        }
    }
}