using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    public Transform patrolRoute; //ref to object whom linked in inspector
    public List<Transform> locations; // add list nav point 
    private NavMeshAgent agent;
    private int locationIdex = 0;
    void InitializePatrolRoute()
    {
        foreach(Transform child in patrolRoute)
        {
            //adding to list
            locations.Add(child);
        }
    }
    void MoveToNextPoint()
    {
        agent.destination = locations[locationIdex].position;
    }
    public void Start()
    {
        InitializePatrolRoute();
        agent = GetComponent<NavMeshAgent>();
        MoveToNextPoint();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.name == "Player")
        {
            Debug.Log("Player has enter to vision");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("Player has leave trigger site");
        }
    }
}
