using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayFourSub : MonoBehaviour
{
    public GameManager gm;

    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");
        gm = g.GetComponent<GameManager>();
    }

    public void CorruptionPlea()
    {
        gm.corruptionPlea = true;
    }

    public void TruceDoc()
    {
        gm.truceDoc = true;
    }

    public void SgtDayFour()
    {
        gm.sgtCommentFour = true;
    }

    public void NewspaperFour()
    {
        gm.newspaperFour = true;
    }

    public void BakerFour()
    {
        gm.bakerNewsFour = true;
    }

    public void MilitaryCrack()
    {
        gm.militaryViolence = true;
    }

    public void SoldierUnionFour()
    {
        gm.soldierDayFour = true;
    }

    public void BakerPtsd()
    {
        gm.ptsdBaker = true;
    }

    public void Militia()
    {
        gm.militia = true;
    }

    public void MilDoc()
    {
        gm.milDoc = true;
    }

    public void Skirmish()
    {
        gm.pmSkir = true;   
    }

    public void SoldierGov()
    {
        gm.soldierDayFourG = true;
    }
}
