using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Transform patrolRoute; //ref to object whom linked in inspector
    public List<Transform> locations; // add list nav point 
    void InitializePatrolRoute()
    {
        foreach(Transform child in patrolRoute)
        {
            //adding to list
            locations.Add(child);
        }
    }
    public void Start()
    {
        InitializePatrolRoute();
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
