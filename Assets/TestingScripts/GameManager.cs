using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    //Day 1 bools
    [Header("Day 1 Bools")]

    public bool seenPoster;
    public bool seenSoldiers;
    public bool watchedTV;
    public bool hasBooklet;
    public bool seenNewspaper;
    public bool sergeantPromise;
    public bool bakerPast;
    public bool govCensor;
    public bool corruptClaim;
    public bool coupRumor;
    public bool uViolence;
    public bool pmRival;

    [Header("Day 1 Modifiers")]
    public bool modPoster;
    public bool bakerNews;
    public bool sergeantViolence;

    [Header("Day 2 Bools")]
    public bool hasPouch;
    public bool givenPouch;
    public bool seenArrestedUni;
    public bool seenArrestedSoldier;
    public bool watchedTVTwo;
    public bool bakerKid;
    public bool soldierConvo;
    public bool bartenderStory;
    public bool hasDocument;

    [Header("Day 2 Modifiers")]
    public bool sgtUnionComment;
    public bool oldBooklet;
    public bool sergeantPhone;

    [Header("Day 3 Bools")]
    public bool bakerBodyM;
    public bool bakerBodyG;
    public bool bartenderBodyU;
    public bool bartenderBodyG;
    public bool sgtBodyU;
    public bool sgtBodyM;
    public bool flag;
    public bool deadSoldiersU;
    public bool deadSoldiersG;
    public bool deadUnionistM;
    public bool deadUnionistG;
    public bool burnDocument;

    [Header("Day 4 Bools")]
    public bool corruptionPlea;
    public bool truceDoc;
    public bool sgtCommentFour;
    public bool newspaperFour;
    public bool bakerNewsFour;
    public bool militaryViolence;
    public bool soldierDayFour;
    public bool ptsdBaker;
    public bool militia;
    public bool milDoc;
    public bool pmSkir; 
    public bool soldierDayFourG;

    [Header("Exposure")]
    public int uniExposure;
    public int govExposure;
    public int milExposure;

    [Header("Debug")]
    public bool hasTalked;
    //public ItemType currentItem;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ModifyUni(int value)
    {
        uniExposure += value;
    }

    public void ModifyMil(int value)
    {
        milExposure += value;
    }

    public void ModifyGov(int value)
    {
        govExposure += value;
    }

}

//public enum ItemType
//{
//    weapon, 
//    armor,
//    potion,
//}