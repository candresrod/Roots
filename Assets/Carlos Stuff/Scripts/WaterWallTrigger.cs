using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWallTrigger : MonoBehaviour
{

    [SerializeField] private Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Fade");
    }

}
