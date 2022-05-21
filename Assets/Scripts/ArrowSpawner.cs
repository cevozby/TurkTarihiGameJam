using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    [SerializeField] private float yMin;
    [SerializeField] float yMax;
    [SerializeField] float speed;
    [SerializeField] float startDelay;
    [SerializeField] float spawnInterval;
    float time = 2.1f;
    public GameObject arrow;

    public Transform cam;
    int count;


    // Start is called before the first frame update
    void Start()
    {
        /*for(int i=0; i <= count; i++)
        {
            StartCoroutine(SpawnSpeed());
        }*/
        //Time.timeScale = 0f;
        InvokeRepeating("SpawnSpeed", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnSpeed()
    {
        if(count <= 10)
        {
            var arrowObject = Instantiate(arrow, new Vector3(cam.position.x + 1.5f, Random.Range(yMin, yMax), 0f), Quaternion.identity);
            arrowObject.transform.parent = gameObject.transform;
            count++;
        }
        
        //yield return new WaitForSeconds(speed);
    }
}
