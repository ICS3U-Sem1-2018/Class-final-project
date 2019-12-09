using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingInventoryItem : MonoBehaviour
{
    public Item item;
    public Item item2;

    private InventorySystem inventory;

    private void Update()
    {
        inventory = FindObjectOfType<InventorySystem>();
        while(true)
        {
            if (CompareTag("key"))
            {
                if (Input.GetKeyDown("space"))
                {
                    inventory.AddItem(item);
                }
                return;
            }
         if (CompareTag("key"))
            {
                if (Input.GetKeyDown("space"))
                {
                    inventory.AddItem(item2);
                }
                return;
            }

        }
    }


    
}
