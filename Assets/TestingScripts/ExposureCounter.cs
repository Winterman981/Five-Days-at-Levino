using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExposureCounter: MonoBehaviour
{
    public TextMeshProUGUI uCounter;
    public TextMeshProUGUI mCounter;
    public TextMeshProUGUI gCounter;

    public string deathMessage = "INACTIVE";

    public GameManager gm;

    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");

        gm = g.GetComponent<GameManager>();
    }

    private void Update()
    {
        uCounter.text = gm.uniExposure.ToString();
        mCounter.text = gm.milExposure.ToString();
        gCounter.text = gm.govExposure.ToString();

        if(gm.UDeath == true)
        {
            uCounter.text = deathMessage.ToString();
        }

        if (gm.MDeath == true)
        {
            mCounter.text = deathMessage.ToString();
        }

        if (gm.GDeath == true)
        {
            gCounter.text = deathMessage.ToString();
        }
    }
}
