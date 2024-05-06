using UnityEngine;

public class platformMovement : MonoBehaviour
{
    public Vector3 startPosition = new Vector3(0, -1.2f, 0);
    public Vector3 endPosition = new Vector3(0, 3f, 0);
    public float speed = 1f;
    public float frequency = 1f;

    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float elapsedTime = Time.time - startTime;
        float t = Mathf.Sin(elapsedTime * speed * Mathf.PI * 2 * frequency) * 0.5f + 0.5f;
        transform.position = Vector3.Lerp(startPosition, endPosition, t);
    }
}
