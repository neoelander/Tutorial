using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab f�r "Enemy"
    public float spawnInterval = 5f; // Tid mellan spawns (i sekunder)
    public float despawnDelay = 7f; // Tid innan objektet f�rsvinner (i sekunder)
    private float timer; // Timer f�r att sp�ra spawntid

    void Start()
    {
        timer = spawnInterval; // Initiera timer
    }

    void Update()
    {
        timer -= Time.deltaTime; // Uppdatera timer

        // Spawna "Enemy" om timern �r 0 eller mindre
        if (timer <= 0)
        {
            GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            Debug.Log("Enemy created. Will be destroyed after " + despawnDelay + " seconds.");
            Destroy(enemy, despawnDelay); // F�rst�r objektet efter despawnDelay
            timer = spawnInterval; // �terst�ll timer
        }
    }
}
