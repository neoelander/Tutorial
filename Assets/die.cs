using UnityEngine;

public class die : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lava"))
        {
            Transform playerTransform = transform;
            playerTransform.position = new Vector2(-8.31f, -1.8071f);

        }
    }
}
