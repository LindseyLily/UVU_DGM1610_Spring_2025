using UnityEngine;
[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class TriggerParticleEffect : MonoBehaviour
{
    //Particle system
    private ParticleSystem particleSystem;
    // Amount of particles
    public int particleAmount = 10;

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Checks if the player has triggered the event
        if (other.gameObject.GetComponent<CharacterController>())
        {
            //Emits the particles
            particleSystem.Emit(particleAmount);
        }
    }
}
