using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCanvasThree : MonoBehaviour
{
    public GameManager gm;
    public SubmitManager sm;

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
    public GameObject button11;
    public GameObject button12;

    public GameObject mystery1;
    public GameObject mystery2;

    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");
        gm = g.GetComponent<GameManager>();
        sm = g.GetComponent<SubmitManager>();

        GameCheck();
    }

    public void Update()
    {

    }

    public void GameCheck()
    {
        if (gm.sgtBodyU == true)
        {
            button1.gameObject.SetActive(true);
            mystery1.gameObject.SetActive(false);

            if (sm.submitSgtBody == true)
            {
                button1.gameObject.SetActive(false);
            }
        }

        if (gm.flag == true)
        {
            button2.gameObject.SetActive(true);
            mystery2.gameObject.SetActive(false);

            if (sm.submitFlag == true)
            {
                button2.gameObject.SetActive(false);
            }
        }

        if (gm.bartenderBodyU == true)
        {
            button3.gameObject.SetActive(true);
            mystery1.gameObject.SetActive(false);

            if (sm.submitBartenderBody == true)
            {
                button3.gameObject.SetActive(false);
            }
        }

        if (gm.deadSoldiersU == true)
        {
            button4.gameObject.SetActive(true);
            mystery2.gameObject.SetActive(false);

            if (sm.submitSoldierBody == true)
            {
                button4.gameObject.SetActive(false);
            }
        }

        if (gm.bakerBodyM == true)
        {
            button5.gameObject.SetActive(true);
            mystery1.gameObject.SetActive(false);

            if (sm.submitBakerBody == true)
            {
                button5.gameObject.SetActive(false);
            }
        }

        if (gm.deadUnionistM == true)
        {
            button6.gameObject.SetActive(true);
            mystery2.gameObject.SetActive(false);

            if (sm.submitUnionBody == true)
            {
                button6.gameObject.SetActive(false);
            }
        }

        if (gm.sgtBodyM == true)
        {
            button7.gameObject.SetActive(true);
            mystery1.gameObject.SetActive(false);

            if (sm.submitSgtBody == true)
            {
                button7.gameObject.SetActive(false);
            }
        }

        if (gm.burnDocument == true)
        {
            button8.gameObject.SetActive(true);
            mystery2.gameObject.SetActive(false);

            if (sm.submitBurnDoc == true)
            {
                button8.gameObject.SetActive(false);
            }
        }

        if (gm.bartenderBodyG == true)
        {
            button9.gameObject.SetActive(true);
            mystery1.gameObject.SetActive(false);

            if (sm.submitBartenderBody == true)
            {
                button9.gameObject.SetActive(false);
            }
        }

        if (gm.deadSoldiersG == true)
        {
            button10.gameObject.SetActive(true);
            mystery2.gameObject.SetActive(false);

            if (sm.submitSoldierBody == true)
            {
                button10.gameObject.SetActive(false);
            }
        }

        if (gm.bakerBodyG == true)
        {
            button11.gameObject.SetActive(true);
            mystery1.gameObject.SetActive(false);

            if (sm.submitBartenderBody == true)
            {
                button11.gameObject.SetActive(false);
            }
        }

        if (gm.deadUnionistG == true)
        {
            button12.gameObject.SetActive(true);
            mystery2.gameObject.SetActive(false);

            if (sm.submitBartenderBody == true)
            {
                button12.gameObject.SetActive(false);
            }
        }
    }

    public void SgtDeathU()
    {
        gm.ModifyUni(-2);
        Destroy(button1);

        sm.submitSgtBody = true;
    }

    public void BurnFlag()
    {
        gm.ModifyUni(-2);
        Destroy(button2);

        sm.submitFlag = true;
    }

    public void BartenderDeath()
    {
        gm.ModifyUni(-2);
        Destroy(button3);

        sm.submitBartenderBody = true;
    }

    public void SoldierDeathU()
    {
        gm.ModifyUni(-2);
        Destroy(button4);

        sm.submitSoldierBody = true;
    }

    public void BakerDeathM()
    {
        gm.ModifyMil(-3);
        Destroy(button5);

        sm.submitBakerBody = true;
    }

    public void UnionistM()
    {
        gm.ModifyMil(-3);
        Destroy(button6);

        sm.submitUnionBody = true;
    }

    public void SgtDeathM()
    {
        gm.ModifyMil(-3);
        Destroy(button7);

        sm.submitSgtBody = true;
    }

    public void BurningDocument()
    {
        gm.ModifyMil(-4);
        Destroy(button8);

        sm.submitBurnDoc = true;
    }

    public void BartenderArrest()
    {
        gm.ModifyGov(2);
        Destroy(button9);

        sm.submitBartenderBody = true;
    }

    public void SoldierDeathG()
    {
        gm.ModifyGov(-2);
        Destroy(button10);

        sm.submitSoldierBody = true;
    }
    public void BakerDeathG()
    {
        gm.ModifyGov(-1);
        Destroy(button11);

        sm.submitBakerBody = true;
    }

    public void UnionistG()
    {
        gm.ModifyGov(-3);
        Destroy(button12);

        sm.submitUnionBody = true;
    }

}