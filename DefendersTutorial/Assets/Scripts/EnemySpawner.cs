using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    //Create an enemy pool 
    int poolSize = 25;
    int topOfPool;

    public List<Transform> spawnLocations;
    int nextSpawnLocation = 0;

    float waveSpawnDelay = 5f;

    List<GameObject> enemies;
    GameObject enemy;
    float spreadDistance = 3f;

    void Awake()
    {
        foreach (Transform t in spawnLocations) t.gameObject.SetActive(true);
    }

}
