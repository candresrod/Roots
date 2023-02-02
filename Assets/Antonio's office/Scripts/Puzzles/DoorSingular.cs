using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSingular : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject buttonOn;

    private void Update()
    {
        if (buttonOn.activeSelf == false)
        {
            door.GetComponent<Animator>().SetTrigger("DoorOpenTrigger");
        }
    }
}
