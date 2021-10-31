using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractDetection : MonoBehaviour
{
    [SerializeField] private float interactRange;
    public GameObject button;
    public LayerMask whatIsPlayer;

    private void Start()
    {
        button.gameObject.SetActive(false);
    }

    void Update()
    {
        var collider = Physics2D.OverlapCircle(transform.position, interactRange, whatIsPlayer);
        if (collider != null)
        {
            if(collider.gameObject.tag == "Player")
            {
                button.gameObject.SetActive(true);
            }
        }

        else
        {
            button.gameObject.SetActive(false);
        }
    }

    void OnDrawGizmoSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, interactRange);
    }
}
