using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bullet"))
        {
            // Om objektet nuddar ett objekt med taggen "Bullet", försvinner det.
            Destroy(gameObject);
        }
    }
}
