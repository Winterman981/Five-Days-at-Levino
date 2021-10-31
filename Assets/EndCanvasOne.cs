using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCanvasOne : MonoBehaviour
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
    public GameObject button11;
    public GameObject button12;
    public GameObject button13;

    public GameObject mystery1;
    public GameObject mystery2;
    public GameObject mystery3;
    public GameObject mystery4;
    public GameObject mystery5;
    public GameObject mystery6;
    public GameObject mystery7;
    public GameObject mystery8;
    public GameObject mystery9;
    public GameObject mystery10;

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
        if(gm.bakerPast == true)
        {
            button1.gameObject.SetActive(true);
            mystery1.gameObject.SetActive(false);
        }

        if (gm.seenPoster == true)
        {
            button2.gameObject.SetActive(true);
            mystery2.gameObject.SetActive(false);
        }

        if (gm.govCensor == true)
        {
            button3.gameObject.SetActive(true);
            mystery3.gameObject.SetActive(false);
        }

        if (gm.corruptClaim == true)
        {
            button4.gameObject.SetActive(true);
            mystery4.gameObject.SetActive(false);
        }

        if (gm.watchedTV == true)
        {
            button5.gameObject.SetActive(true);
            mystery5.gameObject.SetActive(false);
        }

        if (gm.seenNewspaper == true)
        {
            button6.gameObject.SetActive(true);
            mystery6.gameObject.SetActive(false);
        }

        if (gm.hasBooklet == true)
        {
            button7.gameObject.SetActive(true);
            mystery7.gameObject.SetActive(false);
        }

        if (gm.coupRumor == true)
        {
            button8.gameObject.SetActive(true);
            mystery8.gameObject.SetActive(false);
        }

        if (gm.uViolence == true)
        {
            button9.gameObject.SetActive(true);
            mystery9.gameObject.SetActive(false);
        }

        if (gm.pmRival == true)
        {
            button10.gameObject.SetActive(true);
            mystery10.gameObject.SetActive(false);
        }
    }

    public void ModCheck()
    {
        if(gm.modPoster == true && gm.seenPoster == true)
        {
            button2.gameObject.SetActive(false);
            button11.gameObject.SetActive(true);
        }

        if (gm.bakerNews == true && gm.watchedTV == true)
        {
            button5.gameObject.SetActive(false);
            button12.gameObject.SetActive(true);
        }

        if (gm.uViolence == true && gm.sergeantViolence == true)
        {
            button9.gameObject.SetActive(false);
            button13.gameObject.SetActive(true);
        }
    }

    public void BakerPast()
    {
        gm.ModifyMil(-1);
        Destroy(button1);
    }

    public void UPoster()
    {
        gm.ModifyUni(1);
        Destroy(button2);
    }

    public void Censor()
    {
        gm.ModifyGov(-2);
        Destroy(button3);
    }

    public void TVnews()
    {
        gm.ModifyGov(-2);
        Destroy(button5);
    }

    public void Newspaper()
    {
        gm.ModifyGov(-2);
        Destroy(button6);
    }

    public void Booklet()
    {
        gm.ModifyMil(1);
        Destroy(button7);
    }

    public void Coup()
    {
        gm.ModifyMil(1);
        Destroy(button8);
    }

    public void UViolence()
    {
        gm.ModifyUni(-1);
        Destroy(button9);
    }

    public void Rivals()
    {
        gm.ModifyGov(-1);
        gm.ModifyMil(-1);
        Destroy(button10);
    }

    public void PosterMod()
    {
        gm.ModifyUni(2);
        Destroy(button11);
    }

    public void BakerNews()
    {
        gm.ModifyGov(-2);
        gm.ModifyUni(1);
        Destroy(button12);
    }

    public void SergeantViolence()
    {
        gm.ModifyUni(-2);
        Destroy(button13);
    }
}
