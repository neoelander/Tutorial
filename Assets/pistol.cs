using UnityEngine;

public class pistol : MonoBehaviour
{
    protected Transform playerTransform;

    protected virtual void Start()
    {
        // Hitta spelarens transform-komponent n�r objektet skapas
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    protected virtual void Update()
    {
        // F�lj med spelarens position i b�de x- och y-axeln
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);

        // R�ra sig upp och ner med muspekaren (endast �ndra rotationen)
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }
}
