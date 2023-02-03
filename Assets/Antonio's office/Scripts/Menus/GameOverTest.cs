using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTest : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject gameOverMenu;

    //Timer Variables
    private float currentTime;
    private float timeLimit = 3f;

    private bool timerStart = false;

    private void FixedUpdate()
    {
        if (timerStart == true)
        {
            currentTime += Time.deltaTime;
            Debug.Log(currentTime);

            if (currentTime >= timeLimit)
            {
                SceneManager.LoadScene("Main Menu");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       
        
            player.SetActive(false);
            gameOverMenu.SetActive(true);

            timerStart = true;

            
        
    }
}
