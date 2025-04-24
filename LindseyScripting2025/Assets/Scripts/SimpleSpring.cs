using UnityEngine;

public class SimpleSpring : MonoBehaviour
{
    public GameObject connectedObject;
    public float springConstant = 10f;
    public float damping = 5f;
    public float restLength = 1f;

    void FixedUpdate()
    {
        if (connectedObject == null)
        {
            return;
        }

        // Calculate the distance between the two objects
        float distance = Vector3.Distance(transform.position, connectedObject.transform.position);

        // Calculate the spring force
        float springForce = (distance - restLength) * springConstant;

        // Calculate the damping force (opposes velocity)
        Vector3 relativeVelocity = (connectedObject.GetComponent<Rigidbody>().velocity - GetComponent<Rigidbody>().velocity);
        float dampingForce = damping * relativeVelocity.magnitude;

        // Calculate the total force
        Vector3 totalForce = (transform.position - connectedObject.transform.position).normalized * (springForce - dampingForce);

        // Apply the force to the connected object
        connectedObject.GetComponent<Rigidbody>().AddForce(totalForce, ForceMode.Acceleration);
    }
}
