using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCanvasOne : MonoBehaviour
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
        sm = g.GetComponent<SubmitManager>();

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

            if(sm.submitBakerPast == true)
            {
                button1.gameObject.SetActive(false);
            }
        }

        if (gm.seenPoster == true)
        {
            button2.gameObject.SetActive(true);
            mystery2.gameObject.SetActive(false);

            if (sm.submitUPoster == true)
            {
                button2.gameObject.SetActive(false);
            }
        }

        if (gm.govCensor == true)
        {
            button3.gameObject.SetActive(true);
            mystery3.gameObject.SetActive(false);

            if (sm.submitGovCensor == true)
            {
                button3.gameObject.SetActive(false);
            }
        }

        if (gm.corruptClaim == true)
        {
            button4.gameObject.SetActive(true);
            mystery4.gameObject.SetActive(false);

            //if (sm.submitCorruption == true)
            //{
            //    button4.gameObject.SetActive(false);
            //}
        }

        if (gm.watchedTV == true)
        {
            button5.gameObject.SetActive(true);
            mystery5.gameObject.SetActive(false);

            if (sm.submitTVNews == true)
            {
                button5.gameObject.SetActive(false);
            }
        }

        if (gm.seenNewspaper == true)
        {
            button6.gameObject.SetActive(true);
            mystery6.gameObject.SetActive(false);

            if (sm.submitNewspaper == true)
            {
                button6.gameObject.SetActive(false);
            }
        }

        if (gm.hasBooklet == true)
        {
            button7.gameObject.SetActive(true);
            mystery7.gameObject.SetActive(false);

            if (sm.submitBooklet == true)
            {
                button7.gameObject.SetActive(false);
            }
        }

        if (gm.coupRumor == true)
        {
            button8.gameObject.SetActive(true);
            mystery8.gameObject.SetActive(false);

            if (sm.submitCoupRumor == true)
            {
                button8.gameObject.SetActive(false);
            }
        }

        if (gm.uViolence == true)
        {
            button9.gameObject.SetActive(true);
            mystery9.gameObject.SetActive(false);

            if (sm.submitUViolence == true)
            {
                button9.gameObject.SetActive(false);
            }
        }

        if (gm.pmRival == true)
        {
            button10.gameObject.SetActive(true);
            mystery10.gameObject.SetActive(false);

            if (sm.submitPMRival == true)
            {
                button10.gameObject.SetActive(false);
            }
        }
    }

    public void ModCheck()
    {
        if(gm.modPoster == true && gm.seenPoster == true)
        {
            button2.gameObject.SetActive(false);
            button11.gameObject.SetActive(true);

            if (sm.submitPosterMod == true)
            {
                button11.gameObject.SetActive(false);
            }
        }

        if (gm.bakerNews == true && gm.watchedTV == true)
        {
            button5.gameObject.SetActive(false);
            button12.gameObject.SetActive(true);

            if (sm.submitBakerNews == true)
            {
                button12.gameObject.SetActive(false);
            }
        }

        if (gm.uViolence == true && gm.sergeantViolence == true)
        {
            button9.gameObject.SetActive(false);
            button13.gameObject.SetActive(true);

            if (sm.submitSgtViolence == true)
            {
                button13.gameObject.SetActive(false);
            }
        }
    }

    public void BakerPast()
    {
        gm.ModifyMil(-1);
        Destroy(button1);
        sm.submitBakerPast = true;
    }

    public void UPoster()
    {
        gm.ModifyUni(1);
        Destroy(button2);
        sm.submitUPoster = true;
    }

    public void Censor()
    {
        gm.ModifyGov(-2);
        Destroy(button3);
        sm.submitGovCensor = true;
    }

    public void TVnews()
    {
        gm.ModifyGov(-2);
        Destroy(button5);
        sm.submitTVNews = true;
    }

    public void Newspaper()
    {
        gm.ModifyGov(-2);
        Destroy(button6);
        sm.submitNewspaper = true;
    }

    public void Booklet()
    {
        gm.ModifyMil(1);
        Destroy(button7);
        sm.submitBooklet = true;
    }

    public void Coup()
    {
        gm.ModifyMil(1);
        Destroy(button8);
        sm.submitCoupRumor = true;
    }

    public void UViolence()
    {
        gm.ModifyUni(-1);
        Destroy(button9);
        sm.submitUViolence = true;
    }

    public void Rivals()
    {
        gm.ModifyGov(-1);
        gm.ModifyMil(-1);
        Destroy(button10);
        sm.submitPMRival = true;
    }

    public void PosterMod()
    {
        gm.ModifyUni(2);
        Destroy(button11);
        sm.submitPosterMod = true;
    }

    public void BakerNews()
    {
        gm.ModifyGov(-2);
        gm.ModifyUni(1);
        Destroy(button12);
        sm.submitBakerNews = true;
    }

    public void SergeantViolence()
    {
        gm.ModifyUni(-2);
        Destroy(button13);
        sm.submitSgtViolence = true;
    }
}
