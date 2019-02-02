// This script is used for Impaired, but can be applied to any pause menu screen by Lauren Stamp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    
    public string restart;

    public string mainMenu;

    public bool isPaused;

    public GameObject pauseMenuCanvas;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPaused)
        {
            // activates the pause menu canvas (screen background, text and buttons appear)
            pauseMenuCanvas.SetActive(true);
            // makes the game stop working (character, monster, timer stops)
            Time.timeScale = 0f;
        }
        else
        {
            // pause menu isn't visible, game is operational
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
        // If escape key is pressed down (again), game is no longer paused
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
    }

    public void Resume()
    {
        // game is resumed
        isPaused = false;
    }

    public void Restart()
    {
        // restarts the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToMenu()
    {
        // loads the menu scene
        SceneManager.LoadScene(mainMenu);
    }
}
