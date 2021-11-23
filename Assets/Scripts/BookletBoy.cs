using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BookletBoy : MonoBehaviour
{
    public GameManager gm;
    public GameObject button;

    Vector2 Direction;

    [SerializeField] Transform target;
    NavMeshAgent agent;

    void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");
        gm = g.GetComponent<GameManager>();

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        button.gameObject.SetActive(false);
    }

    void Update()
    {
        BookletWalk();
    }

    public void BookletWalk()
    {
        Vector2 targetPos = target.position;

        Direction = targetPos - (Vector2)transform.position;

        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Direction);

        if (gm.hasBooklet == true)
        {
            transform.up = Direction;
            agent.SetDestination(target.position);
        }
    }
}
