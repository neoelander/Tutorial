using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f; 

    private bool movingRight = true; 


    void Update()
    {

        if (transform.position.x >= 7.22f)
        {
            movingRight = false;
        }
        else if (transform.position.x <= 5.05f)
        {
            movingRight = true;
        }
        float direction = movingRight ? 1 : -1;
        float movement = speed * direction * Time.deltaTime;
        transform.Translate(new Vector3(movement, 0, 0));
    }
}
