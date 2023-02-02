using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInLand : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] GameObject gameOverMenu;

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

            }
        }
    }

}
