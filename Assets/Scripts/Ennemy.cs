using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;


public class Ennemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public List<Transform> waypoints;
    public float speed = 8f;
    private int nextDest;
    public enum States
    {
        Patrol,
        Chase,
        Research,
        Idle
    }

    public States SwitchState(States currentState)
    {
        switch (currentState)
        {
            case (States.Patrol):
                break;
            case (States.Chase):
                break;
            case (States.Research):
                break;
            case States.Idle:
                
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(currentState), currentState, null);
        }

        return currentState;
    }

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = waypoints[nextDest].position;
        if (transform.position != waypoints[nextDest].position) return;
        nextDest++;

        if (nextDest != waypoints.Count) return;
        nextDest = 0;
        
        waypoints.Reverse();
    }

    public void OnTriggerEnter(Collider other)
    {
        
    }
}
