using UnityEngine;

public class getGun : MonoBehaviour
{
    // Detta anropas n�r en annan Collider2D r�r den h�r spelarens Collider2D
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Kolla om det kolliderande objektet har taggen "glock"
        if (other.CompareTag("glock"))
        {
            // F�rst�r det kolliderande objektet
            Destroy(other.gameObject);

        }
    }
}
