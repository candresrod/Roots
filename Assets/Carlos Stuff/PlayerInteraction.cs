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
            boat.SetActive(false);
            player.SetActive(true);
            inBoat = false;
        }
        else
        {
            boat.SetActive(true);
            player.SetActive(false);
            inBoat = true;
        }
    }

}
