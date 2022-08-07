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

        if(availableHideouts == null)
        {
            Debug.Log("Victoire");
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
