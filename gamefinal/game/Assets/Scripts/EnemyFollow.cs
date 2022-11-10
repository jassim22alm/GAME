using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;//This is a reference variable to navmesh
    public Transform player;//This is a reference variable which is a target to the navmesh agent,in this case player is the target
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);//Destination to the enemy
    }
}
