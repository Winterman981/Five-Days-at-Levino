using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayTwoSub : MonoBehaviour
{
    public GameManager gm;

    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");
        gm = g.GetComponent<GameManager>();
    }

    public void CorruptionModify()
    {
        if(gm.corruptClaim == true)
        {
            gm.sergeantPhone = true;
        }
    }

    public void BakerBooklet()
    {
        if (gm.hasBooklet == true)
        {
            gm.oldBooklet = true;
        }
    }

    public void SergeantComment()
    {
        if (gm.seenArrestedUni == true)
        {
            gm.sgtUnionComment = true;
        }
    }

    public void BakerNewsTwo()
    {
        gm.bakerKid = true;
    }

    public void SeenTVTwo()
    {
        gm.watchedTVTwo = true;
    }

    public void SeenInterrogate()
    {
        gm.seenArrestedSoldier = true;
    }

    public void SeenArrest()
    {
        gm.seenArrestedUni = true;
    }

    public void BartenderStory()
    {
        gm.bartenderStory = true;
    }

    public void SgtDocument()
    {
        if(gm.sergeantPromise == true)
        {
            gm.hasDocument = true;
        }
    }

    public void FoundPouch()
    {
        gm.hasPouch = true;
    }

    public void barEavesdrop()
    {
        gm.soldierConvo = true;
    }

    public void GivePouch()
    {
        gm.givenPouch = true;
        gm.hasPouch = false;
    }
}
