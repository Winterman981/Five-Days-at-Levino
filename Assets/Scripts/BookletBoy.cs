using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BookletBoy : MonoBehaviour
{
    public GameManager gm;

    [SerializeField] Transform target;
    NavMeshAgent agent;

    void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");
        gm = g.GetComponent<GameManager>();

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    void Update()
    {
        BookletWalk();
    }

    public void BookletWalk()
    {
        if(gm.hasBooklet == true)
        {
            agent.SetDestination(target.position);
        }
    }
}
