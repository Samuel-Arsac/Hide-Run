using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : LocalManager<UIManager>
{
    [SerializeField] private GameObject victorySection;
    [SerializeField] private GameObject pauseSection;

    #region Pause

    public void DisplayPauseSection()
    {
        pauseSection.SetActive(true);
    }

    public void HidePauseSection()
    {
        pauseSection.SetActive(false);
    }

    #endregion

    #region Victory

    public void DisplayVictorySection()
    {
        victorySection.SetActive(true);
    }

    public void HideVictorySection()
    {
        victorySection.SetActive(false);
    }

    #endregion
}
