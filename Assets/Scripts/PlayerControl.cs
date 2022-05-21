using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float speed;

    Vector2 movement;

    bool isWalking = false;

    Rigidbody2D playerRB;
    Animator playerAnim;
    SpriteRenderer playerSR;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        //playerAnim = GetComponent<Animator>();
        playerSR = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if(!LevelCheck.kursadCheck && !LevelCheck.textCheck)
        {
            playerRB.velocity = movement * speed;
        }
        else if(LevelCheck.kursadCheck || LevelCheck.textCheck)
        {
            playerRB.velocity = Vector2.zero;
            //playerAnim.SetBool("IsWalking", false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerAnimation();
    }

    void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    /*void PlayerAnimation()
    {
        if (playerRB.velocity != Vector2.zero)
        {
            if (movement.x < 0)
            {
                playerSR.flipX = true;
            }
            else
            {
                playerSR.flipX = false;
            }
            isWalking = true;
            playerAnim.SetBool("IsWalking", isWalking);
            playerAnim.SetFloat("X", movement.x);
            playerAnim.SetFloat("Y", movement.y);

        }
        else
        {
            isWalking = false;
            playerAnim.SetBool("IsWalking", isWalking);
            playerAnim.SetFloat("X", movement.x);
            playerAnim.SetFloat("Y", movement.y);
        }

    }*/
}
