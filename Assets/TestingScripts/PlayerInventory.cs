using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private Inventory inventory;

    private void Awake()
    {
        inventory = new Inventory();
    }
}
