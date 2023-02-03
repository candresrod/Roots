using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Continue()
    {
        animator.SetTrigger("Start");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Naomi Scene");
    }

}
