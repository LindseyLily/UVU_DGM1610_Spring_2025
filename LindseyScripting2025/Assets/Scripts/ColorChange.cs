using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color newColor = Color.magenta;
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = newColor;
    }
}

