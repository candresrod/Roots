using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    [SerializeField]
    private GameObject boat;
    [SerializeField]
    private GameObject player;

    private PlayerInLand playerInLand;

    public bool inBoat = false;

    private void Awake()
    {
        playerInLand = GetComponent<PlayerInLand>();
    }

    private void OnBoat()
    {

        if (inBoat)
        {

            if (playerInLand.inLand)
            {
                player.SetActive(true);
                boat.SetActive(false);
                inBoat = false;
            }

        }
        else
        {
            player.SetActive(false);
            boat.SetActive(true);
            inBoat = true;
        }

    }

}
