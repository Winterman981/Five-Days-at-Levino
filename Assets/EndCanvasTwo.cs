using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCanvasTwo : MonoBehaviour
{
    public GameManager gm;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button10;

    public GameObject mystery1;
    public GameObject mystery2;
    public GameObject mystery3;
    public GameObject mystery4;
    public GameObject mystery5;
    public GameObject mystery6;
    public GameObject mystery7;

    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");
        gm = g.GetComponent<GameManager>();

        GameCheck();
        ModCheck();

    }

    public void Update()
    {

    }

    public void GameCheck()
    {
        if (gm.bakerKid == true)
        {
            button1.gameObject.SetActive(true);
            mystery1.gameObject.SetActive(false);
        }

        if (gm.oldBooklet == true)
        {
            button2.gameObject.SetActive(true);
            mystery2.gameObject.SetActive(false);
        }

        if (gm.soldierConvo == true)
        {
            button3.gameObject.SetActive(true);
            mystery3.gameObject.SetActive(false);
        }

        if (gm.bartenderStory == true)
        {
            button4.gameObject.SetActive(true);
            mystery4.gameObject.SetActive(false);
        }

        if (gm.hasDocument == true)
        {
            button5.gameObject.SetActive(true);
            mystery5.gameObject.SetActive(false);
        }

        if (gm.seenArrestedUni == true)
        {
            button6.gameObject.SetActive(true);
            mystery6.gameObject.SetActive(false);
        }

        if (gm.seenArrestedSoldier == true)
        {
            button7.gameObject.SetActive(true);
            mystery7.gameObject.SetActive(false);
        }
    }

    public void ModCheck()
    {
        if (gm.corruptClaim == true && gm.sergeantPhone == true)
        {
            button8.gameObject.SetActive(false);
            button9.gameObject.SetActive(true);
        }

        if (gm.seenArrestedUni == true && gm.sgtUnionComment == true)
        {
            button6.gameObject.SetActive(false);
            button10.gameObject.SetActive(true);
        }
    }

    public void BakerKid()
    {
        gm.ModifyGov(-2);
        gm.ModifyUni(2);
        Destroy(button1);
    }

    public void OldBook()
    {
        gm.ModifyMil(-3);
        Destroy(button2);
    }

    public void SoldierEavesdrop()
    {
        gm.ModifyMil(1);
        Destroy(button3);
    }

    public void BartenderComment()
    {
        gm.ModifyMil(1);
        gm.ModifyGov(-1);
        Destroy(button4);
    }

    public void Falsified()
    {
        gm.ModifyGov(2);
        Destroy(button5);
    }

    public void AUnion()
    {
        gm.ModifyUni(-1);
        gm.ModifyGov(1);
        Destroy(button6);
    }

    public void ASoldier()
    {
        gm.ModifyMil(-1);
        gm.ModifyGov(1);
        Destroy(button7);
    }

    public void AUnionMod()
    {
        gm.ModifyUni(-2);
        gm.ModifyGov(1);
        Destroy(button10);
    }

    public void Corruption()
    {
        gm.ModifyGov(-2);
        Destroy(button9);
    }
}
