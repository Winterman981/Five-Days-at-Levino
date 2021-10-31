using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SoldierDayTwo : MonoBehaviour
{
    public GameManager gm;
    public GameObject button;
    public GameObject mystery;

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
        if(gm.hasPouch == true)
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
        agent.SetDestination(target.position);
    }
}
