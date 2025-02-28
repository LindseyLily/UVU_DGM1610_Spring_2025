
using UnityEngine;

public class UIFollowCharacter : MonoBehaviour
{
    public Transform characterTransform;  // The character to follow
    public Vector3 positionOffset;        // Offset from the character (for example, above the character)
    
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();  // Get the RectTransform component of the UI image
        // Ensure the UI image is a child of the character
        transform.SetParent(characterTransform);
    }

    void Update()
    {
        // Position the UI element relative to the character's position with an optional offset
        rectTransform.localPosition = positionOffset;
    }
}
