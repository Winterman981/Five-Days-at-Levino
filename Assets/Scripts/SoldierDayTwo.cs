using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SoldierDayTwo : MonoBehaviour
{
    public GameManager gm;
    public GameObject button;
    public GameObject mystery;

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
        SoldierWalk();
    }

    public void SoldierWalk()
    {
        Vector2 targetPos = target.position;

        Direction = targetPos - (Vector2)transform.position;

        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Direction);

        if (gm.hasPouch == true)
        {
            mystery.gameObject.SetActive(false);
            button.gameObject.SetActive(true);
        }

        if (gm.givenPouch == true)
        {
            StartCoroutine(SoldierAI());
        }
    }

    IEnumerator SoldierAI()
    {
        yield return new WaitForSeconds(3f);
        transform.up = Direction;
        agent.SetDestination(target.position);
    }
}
