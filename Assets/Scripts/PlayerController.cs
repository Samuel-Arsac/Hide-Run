using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class PlayerController : LocalManager<PlayerController>
{
    [SerializeField] private NavMeshAgent playerAgent;
    [SerializeField] private Transform agentTransform;
    private Vector3 target;
    private bool isMoving = false;

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
    }
}
