using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pouch : MonoBehaviour
{
    public GameManager gm;
    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");

        gm = g.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.hasPouch == true)
        {
            //Destroy(this.gameObject);
        }
    }
}
