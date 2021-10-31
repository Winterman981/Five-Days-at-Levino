using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talked : MonoBehaviour
{
    public GameManager gm;

    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");

        gm = g.GetComponent<GameManager>();
    }

    public void TalkChange()
    {
        gm.hasTalked = true;
    }
}
