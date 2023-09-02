using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public GameObject objectPrefab; //prefab of object to spawn
    public Transform spawnArea; //spawn Area
    public float spawnInterval = 2f; //time betwee spawn in seconds

    void Start()
    {
        InvokeRepeating("SpawnObject",0f,spawnInterval);
    }

    void SpawnObject()
    {
        if (objectPrefab != null && spawnArea != null)
        {
            Vector3 randomPosition = new Vector3(

                    Random.Range(spawnArea.position.x - spawnArea.localScale.x / 2, spawnArea.position.x + spawnArea.localScale.x/2),
                    Random.Range(spawnArea.position.y - spawnArea.localScale.y / 2, spawnArea.position.y + spawnArea.localScale.y / 2),
                    Random.Range(spawnArea.position.z - spawnArea.localScale.z / 2, spawnArea.position.z + spawnArea.localScale.z / 2)
                );
            Instantiate(objectPrefab,randomPosition,Quaternion.identity);
        }
    }

}
