using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        //Writes message when triggered
        triggerEvent.Invoke();
        Debug.Log("Player interacted with the object!");
    }
}
