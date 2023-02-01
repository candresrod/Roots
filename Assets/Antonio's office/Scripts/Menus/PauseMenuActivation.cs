using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuActivation : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject player;

    private void OnPauseMenu()
    {
        player.SetActive(false);
        pauseMenu.SetActive(true);

    }

    private void Update()
    {
        
    }

}
