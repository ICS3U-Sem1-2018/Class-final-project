using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingInventoryItem : MonoBehaviour
{
    public Item item;

    private InventorySystem inventory;

    private void Update()
    {
        inventory = FindObjectOfType<InventorySystem>();
        inventory.AddItem(item);

    }


    
}
