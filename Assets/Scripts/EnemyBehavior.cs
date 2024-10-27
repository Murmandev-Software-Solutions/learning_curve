using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    public Transform patrolRoute; //ref to object whom linked in inspector
    public List<Transform> locations; // add list nav point 
    private NavMeshAgent agent;
    private int locationIdex = 0;
    public Transform player;
    private int _lives = 3; //set enemy lives
    public int EnemyLives
    {
        get {return _lives;}
        private set{
            _lives = value;
            if(_lives<=0)
            {
                Destroy(this.gameObject);
                Debug.Log("Enemy destroyed");
            }
        }
    }
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
        if(locations.Count ==0) //if locatoin equal 0 then return
            return;
        
        agent.destination = locations[locationIdex].position;
        locationIdex = (locationIdex +1) % locations.Count; //infinite location points
    }
    public void Start()
    {
        InitializePatrolRoute();
        agent = GetComponent<NavMeshAgent>();
        MoveToNextPoint();
        player = GameObject.Find("Player").transform; //get transform method
    }
    private void OnTriggerEnter(Collider other) {
        if(other.name == "Player")
        {
            agent.destination = player.position;
            Debug.Log("Player has enter to vision");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.name == "Player")
        {
            MoveToNextPoint(); // return to patrol route when leave player
            Debug.Log("Player has leave trigger site");
        }
    }
    void Update()
    {
        if(agent.remainingDistance<0.2f && !agent.pathPending)
        {
            MoveToNextPoint();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Bullet(Clone)")
        {
            EnemyLives-=1;
            Debug.Log("Got a hit");
        }
    }
}
