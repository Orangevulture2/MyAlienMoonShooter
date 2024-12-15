using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnRate = 1.0f;
    public float timeBetweenWaves = 3.0f;

    public int enemyCount;

    public GameObject enemy;

    bool waveIsDone = true;


    // Update is called once per frame
    void Update()
    {
        if (waveIsDone == true) 
        {
            StartCoroutine(waveSpawner());
        }
    }

    IEnumerator waveSpawner() 
    {
        waveIsDone = false;

        for (int i = 0; i < enemyCount; i++)
        {
            GameObject enemyClone = Instantiate(enemy);

            yield return new WaitForSeconds(spawnRate); 
        }
        spawnRate -= 0.1f;

        yield return new WaitForSeconds(timeBetweenWaves);

        waveIsDone = true;
    }
}
