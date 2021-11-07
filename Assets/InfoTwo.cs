using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoTwo : MonoBehaviour
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

        if(gm.sgtUnionComment == true)
        {
            info1.gameObject.SetActive(true);
        }

        if (gm.hasDocument == true)
        {
            info2.gameObject.SetActive(true);
        }

        if (gm.oldBooklet == true)
        {
            info3.gameObject.SetActive(true);
        }

        if (gm.sergeantPhone == true)
        {
            info4.gameObject.SetActive(true);
        }
    }
}
