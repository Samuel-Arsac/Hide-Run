using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideoutManager : LocalManager<HideoutManager>
{
    [SerializeField] private Hideout currentHideout;
    [SerializeField] private List<Hideout> availableHideouts;

    public void SetCurrentHideout(Hideout newHideout)
    {
        currentHideout = newHideout;
    }

    public void SetNextHideouts(List<Hideout> nextHideouts)
    {
        availableHideouts = nextHideouts;
    }

    public void MovementFinished()
    {
        currentHideout.GetComponent<CapsuleCollider>().enabled = false;
        PlayerController.Instance.PlayerIsHidden();

        if(availableHideouts.Count == 0)
        {
            Time.timeScale = 0f;
            GameManager.Instance.CallOnVictory();
            UIManager.Instance.DisplayVictorySection();
        }
        else
        {
            
            foreach (Hideout m in availableHideouts)
            {
                m.GetComponent<MeshRenderer>().enabled = true;
                m.GetComponent<CapsuleCollider>().enabled = true;
            }
        }
    }
}
