using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject player;
    public GameObject obstacle;
    public Transform[] spawnpoints;

    public float spawnpointOffsetToPlayer = 200f; // distance to the player
    public float timeBetweenSpawns = 1f;
    public float distanceBetweenSpawns = 40f;
    public int maxObstaclesInLevel = 25; // old obstacles will be destroyed in-game

    private List<GameObject> allObstacles = new List<GameObject>();

    private float lastDistanceOfObstacle = 160f; // temp counter for distance to obstacle and startpoint of first spawn
    
    void Update()
    {
        SetSpawnerPosition();
        CheckIfObstacleDestroy();

        if (spawnpoints[1].position.z >= lastDistanceOfObstacle)
        {
            SpawnObstacles();
            lastDistanceOfObstacle += distanceBetweenSpawns;
        }    
    }

    private void SpawnObstacles()
    {
        int randomIndex = Random.Range(0, 3);

        for (int i = 0; i < spawnpoints.Length; i++)
        {
            if (randomIndex != i)
            {
                // new GameObject will directly added to the list
                allObstacles.Add((GameObject)Instantiate(obstacle, spawnpoints[i].position, Quaternion.identity));
            }
        }
    }

    private void CheckIfObstacleDestroy() 
    {
        if (allObstacles.Count > maxObstaclesInLevel)
        {
            Destroy(allObstacles[0]);
            allObstacles.RemoveAt(0); // the destroy will make the 0 position NULL so we have to remove it
        }
    }

    private void SetSpawnerPosition()
    {
        transform.position = player.transform.position; // set spawner position to player position

        foreach (Transform spawnpoint in spawnpoints)
        {
            // pushes the spawnpoints in front of the player
            spawnpoint.position = new Vector3(
                  spawnpoint.position.x
                , spawnpoint.position.y
                , transform.position.z + spawnpointOffsetToPlayer
                );
        }
    }
}
