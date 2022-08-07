using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject mainSection;
    [SerializeField] private GameObject selectLevelSection;

    [SerializeField] private Button level2Button;
    [SerializeField] private Button level3Button;
    [SerializeField] private Button level4Button;
    [SerializeField] private Button level5Button;

    #region MainSection
    public void DisplayMainSection()
    {
        mainSection.SetActive(true);
        HideSelectLevel();
    }

    public void HideMainSection()
    {
        mainSection.SetActive(false);
    }
    #endregion

    #region Select Level Section

    public void DisplaySelectLevel()
    {
        if(ProgressionManager.Instance.levelOneCompleted)
        {
            level2Button.interactable = true;
        }
        selectLevelSection.SetActive(true);
        HideMainSection();
    }

    public void HideSelectLevel()
    {
        selectLevelSection.SetActive(false);
    }

    #endregion

    public void LoadSelectedLevel(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
