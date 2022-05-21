using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float yMin, yMax;
    float spawnSpeed;
    GameObject spawnObject;

    public Spawner(float yMin, float yMax, float spawnSpeed, GameObject spawnObject)
    {
        this.yMin = yMin;
        this.yMax = yMax;
        this.spawnSpeed = spawnSpeed;
        this.spawnObject = spawnObject;
    }

    public void Spawn()
    {
        StartCoroutine(SpawnSpeed());
    }

    IEnumerator SpawnSpeed()
    {
        Instantiate(spawnObject, new Vector3(0f, Random.Range(yMin, yMax), 0f), Quaternion.identity);
        yield return new WaitForSeconds(spawnSpeed);
    }

}
