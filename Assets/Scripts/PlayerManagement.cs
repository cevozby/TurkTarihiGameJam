using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManagement : MonoBehaviour
{
    HumanManagement player = new HumanManagement(100, 25, 35);

    public static int health;

    public Slider healthBar;

    public static int damage;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.minValue = 0;
        healthBar.maxValue = player.Health;
        healthBar.value = player.Health;
        health = player.Health;
        damage = player.DamageGenerate();
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!LevelCheck.textCheck)
        {
            Time.timeScale = 1;
        }
        healthBar.value = health;
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            damage = player.DamageGenerate();

            health -= EnemyManager.damage;
        }

        if (collision.gameObject.CompareTag("Arrow"))
        {
            Debug.Log("Oka deðdi");
            Debug.Log("Arrow Damage: " + ArrowManager.damage);
            health -= ArrowManager.damage;
            Debug.Log("Health: " + health);
        }

    }*/

}
