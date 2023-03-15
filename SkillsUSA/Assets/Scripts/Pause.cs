using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void pauseButton()
    {
        pauseMenu.SetActive(true); //pauses game when pressed
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false); //resumes game when pressed
        Time.timeScale = 1f;
    }
    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        //SceneManager.LoadScene(sceneID); // changes scene to home
    }
}
