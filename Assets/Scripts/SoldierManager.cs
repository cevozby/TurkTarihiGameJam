using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierManager : MonoBehaviour
{
    HumanManagement soldier = new HumanManagement(100, 15, 25);

    [SerializeField] float speed;
    public static int health;
    public static int damage;
    int bodyIndex;
    //public List<GameObject> soldiers = new List<GameObject>(40);
    public List<int> healths = new List<int>(40);
    public static SoldierManager current;

    // Start is called before the first frame update
    void Start()
    {
        /*for(int i=0; i<healths.Count; i++)
        {
            healths[i] = soldier.Health;
        }*/
        
        current = this;
        damage = soldier.DamageGenerate();
        health = soldier.Health;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!LevelCheck.textCheck)
        {
            transform.Translate(new Vector3(speed, 0f, 0f));
        }
        
    }

    /*private void Update()
    {
        for(int i = 0; i<healths.Count; i++)
        {
            if(healths[i] <= 0)
            {
                bodyIndex = i;
                Destroy(SoldierController.current.soldiers[i]);
            }
        }
    }*/

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            damage = soldier.DamageGenerate();

            soldier.Health -= EnemyManager.damage;
        }

        if (collision.gameObject.CompareTag("Arrow"))
        {
            soldier.Health -= ArrowManager.damage;
        }

    }*/

}
