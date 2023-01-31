using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    [SerializeField]
    private GameObject boat;
    [SerializeField]
    private GameObject player;

    private bool inBoat = false;

    private void OnBoat()
    {

        if (inBoat)
        {
            player.SetActive(true);
            boat.SetActive(false);
            inBoat = false;
        }
        else
        {
            player.SetActive(false);
            boat.SetActive(true);
            inBoat = true;
        }

    }

}
