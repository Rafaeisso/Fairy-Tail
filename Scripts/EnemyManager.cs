using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject EnemyPrefab;

    public int EnemyCount = 50;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < EnemyCount; i++)
        {
            spawnPosition.y += Random.Range(10f, 15f);
            spawnPosition.x = Random.Range(-3f, 3f);
            Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
