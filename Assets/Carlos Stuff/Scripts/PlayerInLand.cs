using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInLand : MonoBehaviour
{

    private PlayerInteraction playerInteraction;

    private bool inLand = false;
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
            }
        }
    }

}
