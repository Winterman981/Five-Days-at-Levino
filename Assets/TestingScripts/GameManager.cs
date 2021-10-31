using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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

    [Header("Exposure")]
    public int uniExposure;
    public int govExposure;
    public int milExposure;

    [Header("Debug")]
    public bool hasTalked;
    //public ItemType currentItem;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
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