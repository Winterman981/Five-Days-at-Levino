using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayOneSub : MonoBehaviour
{
    public GameManager gm;

    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");
        gm = g.GetComponent<GameManager>();
    }

    public void PosterModify()
    {
        if(gm.seenPoster == true)
        {
            gm.modPoster = true;
        }
    }

    public void BakerNews()
    {
        if (gm.watchedTV == true)
        {
            gm.bakerNews = true;
        }
    }

    public void SergeantComment()
    {
        if (gm.watchedTV == true)
        {
            gm.sergeantViolence = true;
        }
    }

    public void SeenPoster()
    {
        gm.seenPoster = true;
    }

    public void SeenTV()
    {
        gm.watchedTV = true;
    }

    public void SeenSoldier()
    {
        gm.seenSoldiers = true;
    }

    public void HasBooklet()
    {
        gm.hasBooklet = true;
    }

    public void SeenNewspaper()
    {
        gm.seenNewspaper = true;
    }

    public void Promise()
    {
        gm.sergeantPromise = true;
    }

    public void BakerPast()
    {
        gm.bakerPast = true;
    }

    public void GovCensor()
    {
        gm.govCensor = true;
    }

    public void Corruption()
    {
        gm.corruptClaim = true;
    }

    public void CoupRumor()
    {
        gm.coupRumor = true;
    }

    public void UnionViolence()
    {
        gm.uViolence = true;
    }

    public void Rival()
    {
        gm.pmRival = true;
    }
}
