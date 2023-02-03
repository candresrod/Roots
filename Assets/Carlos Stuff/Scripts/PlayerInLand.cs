using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerInLand : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject gameOverMenu;


    //Timer Variables
    private float currentTime;
    private float timeLimit = 3f;
    private bool timerStart = false;
    

    private PlayerInteraction playerInteraction;

    public bool inLand = false;
    private bool dead = false;

    private void Awake()
    {
        playerInteraction = GetComponent<PlayerInteraction>();
    }

    private void Start()
    {
        dead = false;
        timerStart = false;
    }

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
        if (other.CompareTag("Land"))
        {
            inLand = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Land"))
        {
            inLand = false;
            if (!playerInteraction.inBoat)
            {
                dead = true;

                //------------The Following is made by Antonio Berrios (Mr. Berries)

                player.SetActive(false);
                gameOverMenu.SetActive(true);

                timerStart = true;
            }
        }
    }

}
