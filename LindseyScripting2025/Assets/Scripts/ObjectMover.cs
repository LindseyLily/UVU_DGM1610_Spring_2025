using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public float speed = 3f;
    public float distance = 5f;
    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
        
        float y = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
}
}
