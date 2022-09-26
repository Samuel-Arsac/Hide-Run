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

    [SerializeField] private LayerMask whatIsPlayer;
    [SerializeField] private float maxDistanceView;


    private void Start()
    {
        UpdateDestination();
    }

    private void Update()
    {
        if(Vector3.Distance(transform.position, target ) < 1.3)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }


        Vector3 forward = transform.TransformDirection(Vector3.forward) * 3;

        RaycastHit hit;
        if (Physics.Raycast(transform.position, forward, out hit, maxDistanceView, whatIsPlayer))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            PlayerController.Instance.PlayerSeen();
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
