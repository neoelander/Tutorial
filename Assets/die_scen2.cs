using UnityEngine;

public class die_scen2 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lava"))
        {
            Transform playerTransform = transform;

            playerTransform.position = new Vector2(-8.13800049f, -0.399999976f);
        }
    }
}
