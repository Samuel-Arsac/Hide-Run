using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hideout : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private List<Hideout> nextHideouts;
    [SerializeField] private Transform hideoutPostion;

    public void OnPointerClick(PointerEventData data)
    {
        GetComponent<MeshRenderer>().enabled = false;

        PlayerController.Instance.StartMovementAgent(hideoutPostion.position);

        HideoutManager.Instance.SetCurrentHideout(this);
        HideoutManager.Instance.SetNextHideouts(nextHideouts);
    }

}
