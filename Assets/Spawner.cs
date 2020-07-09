using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    public GameObject player;
    public GameObject obstacle;
    public Transform[] spawnpoints;

    public float spawnpointOffsetToPlayer = 50f; // Abstand zu den entstehenden Obstacles
    public float timeBetweenSpawns = 1f; // Abstand zwischen den einzelnen Spawns

    private float timeToSpawn = 2f; // Initial Wert wann der erste Spawn stattfinden soll
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Der Spawner bleibt immer auf der Position des Players stehen
        transform.position = player.transform.position;

        foreach(Transform spawnpoint in spawnpoints)
        {
            // die Position änder sich nur auf der y-Achse damit die Spawnpoints nachgeschoben werden
            spawnpoint.position =  new Vector3(spawnpoint.position.x 
                                                , spawnpoint.position.y 
                                                , transform.position.z + spawnpointOffsetToPlayer);
        }

        if (Time.time >= timeToSpawn)
        {
            SpawnObstacles();
            timeToSpawn = Time.time + timeBetweenSpawns;
        }
        
    }

    private void SpawnObstacles()
    {
        int randomIndex = Random.Range(1, 3);

        for (int i = 0; i < spawnpoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(obstacle, spawnpoints[i].position, Quaternion.identity);
            }
        }
    }
}
