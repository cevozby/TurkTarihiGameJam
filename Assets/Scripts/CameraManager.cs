using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform target;

    public float minX, maxX, minY, maxY;

    float xValue, yValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xValue = Mathf.Clamp(target.transform.position.x, minX, maxX);
        yValue = Mathf.Clamp(target.transform.position.y, minY, maxY);

        if (!LevelCheck.kursadCheck)
        {
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
        }
        if(LevelCheck.kursadCheck && !LevelCheck.textCheck)
        {

        }

    }
}
