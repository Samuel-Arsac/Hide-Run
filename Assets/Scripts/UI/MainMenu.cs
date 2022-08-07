using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject mainSection;
    [SerializeField] private GameObject selectLevelSection;


    public void DisplayMainSection()
    {
        mainSection.SetActive(true);
        HideSelectLevel();
    }

    public void HideMainSection()
    {
        mainSection.SetActive(false);
    }

    public void DisplaySelectLevel()
    {
        selectLevelSection.SetActive(true);
        HideMainSection();
    }

    public void HideSelectLevel()
    {
        selectLevelSection.SetActive(false);
    }

    public void LoadSelectedLevel(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
