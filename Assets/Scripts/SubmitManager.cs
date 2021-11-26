using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubmitManager : MonoBehaviour
{
    public static SubmitManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

	private void Update()
	{
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(this.gameObject);
        }
    }

	[Header("Day 1 Bools")]

    public bool submitBakerPast;
    public bool submitUPoster;
    public bool submitGovCensor;
    public bool submitTVNews;
    public bool submitNewspaper;
    public bool submitBooklet;
    public bool submitCoupRumor;
    public bool submitUViolence;
    public bool submitPMRival;
    public bool submitPosterMod;
    public bool submitBakerNews;
    public bool submitSgtViolence;

    [Header("Day 2 Bools")]

    public bool submitBakerKid;
    public bool submitOldBook;
    public bool submitSoldierED;
    public bool submitBartenderDayTwo;
    public bool submitFalsified;
    public bool submitAUnion;
    public bool submitASoldier;
    public bool submitAUnionMod;
    public bool submitCorruption;

    [Header("Day 3 Bools")]

    public bool submitSgtBody;
    public bool submitBakerBody;
    public bool submitBartenderBody;
    public bool submitSoldierBody;
    public bool submitUnionBody;
    public bool submitFlag;
    public bool submitBurnDoc;
}
