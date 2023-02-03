using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesTrigger : MonoBehaviour
{

    [SerializeField] private GameObject eyes;

    private void OnTriggerEnter(Collider other)
    {
        eyes.SetActive(true);
    }

}
