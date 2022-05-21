using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public GameObject emperorDialogue;
    bool end = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(end && !LevelCheck.textCheck)
        {
            SceneManager.LoadScene("Museum");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kursat"))
        {
            emperorDialogue.SetActive(true);
            LevelCheck.textCheck = true;
            end = true;
            Time.timeScale = 0;
        }
        
        
        
    }

}
