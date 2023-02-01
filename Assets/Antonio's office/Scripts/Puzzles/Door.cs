using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject switchOn1;
    [SerializeField] GameObject switchOn2;
    [SerializeField] GameObject switchOn3;

    private void Update()
    {
        if (switchOn1.activeSelf == false && switchOn2.activeSelf == false && switchOn3.activeSelf == false)
        {
            door.GetComponent<Animator>().SetTrigger("DoorOpenTrigger");
        }
    }
}
