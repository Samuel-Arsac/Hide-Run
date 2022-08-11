using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent guardAgent;
    [SerializeField] private List<Transform> waypoints;
    private int waypointIndex;
    private Vector3 target;

    private void Start()
    {
        UpdateDestination();
    }

    private void Update()
    {
        if(Vector3.Distance(transform.position, target ) < 1.35)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
    }

    public void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        guardAgent.SetDestination(target);
    }

    public void IterateWaypointIndex()
    {
        waypointIndex++;
        if(waypointIndex == waypoints.Count)
        {
            waypointIndex = 0;
        }
    }
}
