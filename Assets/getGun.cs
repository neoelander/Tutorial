using UnityEngine;

public class getGun : MonoBehaviour
{
    // Detta anropas när en annan Collider2D rör den här spelarens Collider2D
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Kolla om det kolliderande objektet har taggen "glock"
        if (other.CompareTag("glock"))
        {
            // Förstör det kolliderande objektet
            Destroy(other.gameObject);

        }
    }
}
