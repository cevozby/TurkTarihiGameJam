using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float yMin;
    [SerializeField] float yMax;
    [SerializeField] float speed;
    [SerializeField] float startDelay;
    [SerializeField] float spawnInterval;
    public GameObject enemy;

    public Transform cam;
    int count;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSpeed", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    void SpawnSpeed()
    {
        var enemyObject = Instantiate(enemy, new Vector3(cam.position.x + 1.5f, Random.Range(yMin, yMax), 0f), Quaternion.identity);
        enemyObject.transform.parent = gameObject.transform;
    }

}
