using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
   // [SerializeField] private GameObject door;
    [SerializeField] private GameObject switchOn1;
    [SerializeField] private GameObject switchOn2;
    [SerializeField] private GameObject switchOn3;
    [SerializeField] private GameObject Temple;

    private void Update()
    {
        if (switchOn1.activeSelf == false && switchOn2.activeSelf == false && switchOn3.activeSelf == false)
        {
            //door.GetComponent<Animator>().SetTrigger("DoorOpenTrigger");
            Temple.SetActive(true);
        }
    }
}
