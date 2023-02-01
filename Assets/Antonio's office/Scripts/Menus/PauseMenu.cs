using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject player;
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        player.SetActive(true);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    private void OnPauseMenu()
    {
        player.SetActive(false);
        pauseMenu.SetActive(true);
    }
}
