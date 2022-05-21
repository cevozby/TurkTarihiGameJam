using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    HumanManagement enemy = new HumanManagement(50, 5, 10);

    [SerializeField] float speed = 0.025f;

    public static int damage, bodyIndex;

    int health;

    // Start is called before the first frame update
    void Start()
    {
        bodyIndex = 0;
        health = enemy.Health;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!LevelCheck.textCheck)
        {
            transform.Translate(Vector3.left * speed);
        }
        
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Kursat"))
        {
            damage = enemy.DamageGenerate();
            PlayerManagement.health -= damage;
            health -= PlayerManagement.damage;

        }
        if (collision.gameObject.CompareTag("Soldier"))
        {
            for (int i = 1; i < SoldierController.current.soldiers.Count; i++)
            {
                if (SoldierController.current.soldiers[i] == collision.gameObject)
                {
                    bodyIndex = i;
                }
            }
            damage = enemy.DamageGenerate();
            SoldierManager.current.healths[bodyIndex] -= damage;
            health -= SoldierManager.damage;
        }
    }
}
