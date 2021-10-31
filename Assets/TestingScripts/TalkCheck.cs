using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkCheck : MonoBehaviour
{
    public GameManager gm;
    public GameObject button;
    public GameObject hidden;

    void Start()
    {
        GameObject g = GameObject.Find("GameManager");

        gm = g.GetComponent<GameManager>();

        if(gm.hasTalked == true)
        {
            button.gameObject.SetActive(true);
            hidden.gameObject.SetActive(false);
        }

        else
        {
            button.gameObject.SetActive(false);
            hidden.gameObject.SetActive(true);
        }
    }

    public void TalkSubmit()
    {
        gm.ModifyGov(-1);
        gm.ModifyUni(2);
        Destroy(this.gameObject);
    }
}
