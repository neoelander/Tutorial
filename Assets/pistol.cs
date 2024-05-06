using UnityEngine;

public class pistol : MonoBehaviour
{
    protected Transform playerTransform;

    protected virtual void Start()
    {
        // Hitta spelarens transform-komponent när objektet skapas
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    protected virtual void Update()
    {
        // Följ med spelarens position i både x- och y-axeln
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);

        // Röra sig upp och ner med muspekaren (endast ändra rotationen)
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }
}
