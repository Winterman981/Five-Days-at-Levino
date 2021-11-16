using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoOne : MonoBehaviour
{
    public GameManager gm;

    public TextMeshProUGUI info1;
    public TextMeshProUGUI info2;
    public TextMeshProUGUI info3;
    public TextMeshProUGUI info4;

    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GameController");
        gm = g.GetComponent<GameManager>();

        if(gm.modPoster == true)
        {
            info1.gameObject.SetActive(true);
        }

        if (gm.sergeantPromise == true)
        {
            info2.gameObject.SetActive(true);
        }

        if (gm.bakerNews == true)
        {
            info3.gameObject.SetActive(true);
        }

        if (gm.sgtUnionComment == true)
        {
            info4.gameObject.SetActive(true);
        }
    }
}
