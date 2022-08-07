using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : LocalManager<GameManager>
{

    #region Pause

    private bool isPaused = false;

    public void PauseGame()
    {
        if(isPaused)
        {
            UIManager.Instance.HidePauseSection();
            Time.timeScale = 1f;
            isPaused = false;
        }
        else
        {
            UIManager.Instance.DisplayPauseSection();
            Time.timeScale = 0f;
            isPaused = true;
        }
    }

    #endregion

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void CallOnVictory()
    {
        switch(SceneManager.GetActiveScene().name)
        {
            case ("Level01"):
                Debug.Log("Level 1 completed");
                ProgressionManager.Instance.ConfirmLevelOneCompletion();
                break;
            case ("Level02"):
                break;
            case ("Level03"):
                break;
            case ("Level04"):
                break;
            case ("Level05"):
                break;
        }
    }


    public void LoadNextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
