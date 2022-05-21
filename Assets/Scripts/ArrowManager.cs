using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour
{
    [SerializeField] float speed = 0.025f;

    public static int damage;

    HumanManagement arrow = new HumanManagement(0, 25, 30);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.left * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Kursat"))
        {
            damage = arrow.DamageGenerate();
            PlayerManagement.health -= damage;
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Soldier"))
        {
            damage = arrow.DamageGenerate();
            SoldierManager.health -= damage;
            Destroy(gameObject);
        }
    }
}
