using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject buttonOn;
    [SerializeField] GameObject buttonOff;

    private bool playerInRange = false;

    void Update()
    {
        if (playerInRange == true)
        {
            buttonOn.SetActive(false);
            buttonOff.SetActive(true); 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }
}
