using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerInteraction : MonoBehaviour
{

    [SerializeField]
    private GameObject boat;
    [SerializeField]
    private GameObject player;

    private PlayerInLand playerInLand;

    [SerializeField] private CinemachineVirtualCamera virtualCamera;

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
                virtualCamera.Priority = 11;
                player.SetActive(true);
                boat.SetActive(false);
                inBoat = false;
            }

        }
        else
        {
            virtualCamera.Priority = 9;
            player.SetActive(false);
            boat.SetActive(true);
            inBoat = true;
        }

    }

}
