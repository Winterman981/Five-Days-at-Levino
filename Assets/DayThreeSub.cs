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

    public void SgtCorpseM()
    {
        gm.sgtBodyM = true;
    }

    public void BakerCorpseM()
    {
        gm.bakerBodyM = true;
    }

    public void BakerCorpseG()
    {
        gm.bakerBodyG = true;
    }

    public void BartenderCorpseU()
    {
        gm.bartenderBodyU = true;
    }

    public void BartenderCorpseG()
    {
        gm.bartenderBodyG = true;
    }

    public void BurningFlag()
    {
        gm.flag = true;
    }

    public void BurningDoc()
    {
        gm.burnDocument = true;
    }

    public void DeadUM()
    {
        gm.deadUnionistM = true;
    }

    public void DeadUG()
    {
        gm.deadUnionistG = true;
    }

    public void DeadMU()
    {
        gm.deadSoldiersU = true;
    }

    public void DeadMG()
    {
        gm.deadSoldiersG = true;
    }
}
