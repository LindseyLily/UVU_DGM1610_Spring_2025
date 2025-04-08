using UnityEngine;
using UnityEngine.Events;

public class SimpleIDMatchBehavior : MonoBehaviour
{
    public Id id;
    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");
        var otherID = other.GetComponent<SimpleIDBehavior>();
        if (otherID.id == id)
        {
            matchEvent.Invoke();
            Debug.Log("Matched ID:" + id);
        }
        else
        {
            noMatchEvent.Invoke();
            Debug.Log("No Match:" + id);
        }
    }
}