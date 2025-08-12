using UnityEngine;

public class RandomForce : MonoBehaviour
{
    public float forceMagnitude = 10f; // Adjust the force magnitude as needed

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Generate a random direction
            Vector3 randomDirection = Random.onUnitSphere; // Random direction on a unit sphere
            // Apply force in the random direction
            rb.AddForce(randomDirection * forceMagnitude, ForceMode.Impulse);
        }
        else
        {
            Debug.LogWarning("Rigidbody component not found on this GameObject.");
        }
    }
}
