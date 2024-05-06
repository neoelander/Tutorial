using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow  : MonoBehaviour
{
    public float speed = 5.0f;
    public float stoppingDistance = 1.0f;

    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Beräkna avståndet mellan fienden och spelaren
        float distance = Vector3.Distance(transform.position, playerTransform.position);

        // Om fienden är längre bort än stoppningsavståndet, flyga mot spelaren
        if (distance > stoppingDistance)
        {
            Vector3 direction = playerTransform.position - transform.position;
            direction.Normalize();
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
