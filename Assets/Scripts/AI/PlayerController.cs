using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
using NaughtyAttributes;

public class PlayerController : LocalManager<PlayerController>
{
    [Header("Agent")]
    [SerializeField] private NavMeshAgent playerAgent;
    [SerializeField] private Transform agentTransform;
    public PlayerStatus currentStatus = PlayerStatus.Hidden;
    private Vector3 target;
    private bool isMoving = false;
    private bool isSeen = false;

    public enum PlayerStatus
    {
        Hidden,
        Visible,
        Seen,
        Spotted,
    }

    public void StartMovementAgent(Vector3 destination)
    {
        target = destination;
        isMoving = true;
    }

    private void Update()
    {
        if(!isMoving)
        {
            return;
        }
        else
        {
            if(playerAgent.transform.position.z == target.z)
            {
                isMoving = false;
                HideoutManager.Instance.MovementFinished();
                return;
            }
            else
            {
                MoveAgentToDesination();
            }
        }
    }

    public void MoveAgentToDesination()
    {
        playerAgent.destination = target;
        PlayerBecomeVisible();
    }

    public void PlayerBecomeVisible()
    {
        currentStatus = PlayerStatus.Visible;
    }

    public void PlayerBecomeSpotted()
    {
        currentStatus = PlayerStatus.Spotted;
    }

    public void PlayerSeen()
    {
        currentStatus = PlayerStatus.Seen;
        isSeen = true;
    }

    public void PlayerIsHidden()
    {
        currentStatus = PlayerStatus.Hidden;
        isSeen = false;
    }
}
