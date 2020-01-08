using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventorySystem : MonoBehaviour
{
     public Item[] items;
    [SerializeField]
    public const int size = 5;

    // Start is called before the first frame update
    void Start()
    {
        items = new Item[size];
        DontDestroyOnLoad(this.gameObject);

    }
    public void AddItem(Item itemToAdd)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = itemToAdd;
                return;
            }
        }
        
    }


    // Update is called once per frame
    void Update()
    {
    }
   
}
