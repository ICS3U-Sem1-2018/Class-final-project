using UnityEngine;

public class AddingItemsInventory : MonoBehaviour
{

    private InventorySystem inventory;
    public Item item1;
    public Item item2;
    public bool item1Check = false;
    public bool item2Check = false;
    void Update()
    {
        if (item1Check == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Debug.Log("pressed for item1");

                inventory.AddItem(item1);
            }
            
        }
        if (item2Check == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Debug.Log("pressed for item2");

                inventory.AddItem(item2);
            }
            
        }
        return;

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        inventory = FindObjectOfType<InventorySystem>();

        if (other.CompareTag("key"))
        {
            item1Check = true;
        }
        if (other.CompareTag("box"))
        {
            item2Check = true;
        }
        return;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("key"))
        {
            item1Check = false;
        }
        if (collision.CompareTag("box"))
        {
            item2Check = false;
        }
    }
}
