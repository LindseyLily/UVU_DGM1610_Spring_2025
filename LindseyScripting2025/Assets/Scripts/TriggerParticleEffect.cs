using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class TriggerParticleEffect : MonoBehaviour
{
    //Particle system
    private ParticleSystem particleSystem;

    public int firstEmissionAmount = 10;
    public int secondEmissionAmount = 20;
    public int thirdEmissionAmount = 30;
    public float delayBetweenEmissions = 0.1f; // Delay time between emissions

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Checks if the player has triggered the event
        if (other.gameObject.GetComponent<CharacterController>())
        {
            StartCoroutine(routine: EmitParticlesCoroutine());
        }
    }
    
    // Coroutine to emit particles multiple times with delays
    private IEnumerator EmitParticlesCoroutine()
    {
        // First emission
        particleSystem.Emit(firstEmissionAmount); // Emit based on exposed variable
        yield return new WaitForSeconds(delayBetweenEmissions); // Wait for a specified time
        
        // Second emission
        particleSystem.Emit(secondEmissionAmount);
        yield return new WaitForSeconds(delayBetweenEmissions);
        
        // Third emission
        particleSystem.Emit(thirdEmissionAmount);
    }
}
