using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayThreeSub : MonoBehaviour
{
    public GameManager gm;

    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");
        gm = g.GetComponent<GameManager>();
    }

    public void SgtCorpseU()
    {
        gm.sgtBodyU = true;
    }

    public void BakerCorpseM()
    {
        gm.bakerBodyM = true;
    }

    public void BartenderCorpseU()
    {
        gm.bartenderBodyU = true;
    }

    public void BurningFlag()
    {
        gm.flag = true;
    }
}
