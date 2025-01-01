using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject coinPrefab;
    public int totalCollectibles = 10;
    public float xRange = 8f;
    public float yRange = 5f;

    void Start()
    {
        SpawnCollectibles();
    }

    void SpawnCollectibles()
    {
        for (int i = 0; i < totalCollectibles; i++)
        {
            // Randomly decide between apple and coin
            GameObject prefab = (Random.value > 0.5f) ? applePrefab : coinPrefab;

            // Generate random position
            float randomX = Random.Range(-xRange, xRange);
            float randomY = Random.Range(-yRange, yRange);
            Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

            // Spawn the collectible
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }
}
