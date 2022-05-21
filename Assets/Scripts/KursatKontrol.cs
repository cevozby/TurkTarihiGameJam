using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KursatKontrol : MonoBehaviour
{
    [SerializeField] float speed = 4f;

    [SerializeField] float yMin;
    [SerializeField] float yMax;

    float yPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed);
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed);
        }
    }

    private void Update()
    {
        yPos = Mathf.Clamp(transform.position.y, yMin, yMax);
        transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
    }
}
