using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject victoryUISection;

    #region Pause

    [SerializeField] private GameObject pauseSection;
    private bool isPaused = false;

    public void PauseGame()
    {
        if(isPaused)
        {
            HidePauseSection();
            Time.timeScale = 1f;
            isPaused = false;
        }
        else
        {
            DisplayPauseSection();
            Time.timeScale = 0f;
            isPaused = true;
        }
    }

    public void DisplayPauseSection()
    {
        pauseSection.SetActive(true);
    }

    public void HidePauseSection()
    {
        pauseSection.SetActive(false);
    }

    #endregion

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void DisplayVictory()
    {
        victoryUISection.SetActive(true);
    }
}
