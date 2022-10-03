using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        enemy.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //enemy.SetDestination(target.position);
        chase();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("triggered");
            //enemy.SetDestination(target.position);
            chase();
        }
    }

    void chase()
    {
        enemy.SetDestination(target.position);
    }
}
