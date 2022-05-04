using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawnScript : MonoBehaviour
{

    private int initAmount = 5;
    private int spawnInterval = 11;
    private int lastSpawnZ = 22;
    private int spawnAmount = 4;

    public List<GameObject> obstacles;

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacles()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            lastSpawnZ += spawnInterval;
        }
        if (Random.Range(0,4) == 0)
        {
            GameObject obstacle = obstacles[Random.Range(0, obstacles.Count)];

            Instantiate(obstacle, new Vector3(0, -0.18f, lastSpawnZ), obstacle.transform.rotation);

            if(Random.Range(0,5) == 1)
            {
                Instantiate(enemy, new Vector3(1, 0, lastSpawnZ + Random.Range(0f, 11f)), enemy.transform.rotation);
            }
            else
            {
             if(Random.Range(0,5) == 1)
            {
              
                Instantiate(enemy, new Vector3(Random.Range(-5f, 5f), 0, lastSpawnZ + Random.Range(0f, 11f)), enemy.transform.rotation);
            }
            }
        }
    }
}
