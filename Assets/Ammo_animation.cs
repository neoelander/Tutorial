using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo_animation : MonoBehaviour
{
    public float minY = 3.56f;
    public float maxY = 4f;
    public float moveDuration = 2f;



    void Update()
    {
        float t = Mathf.PingPong(Time.time / moveDuration, 1f);
        float newY = Mathf.Lerp(minY, maxY, t);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
