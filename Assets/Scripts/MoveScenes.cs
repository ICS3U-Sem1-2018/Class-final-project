using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes : MonoBehaviour
{
    private InventorySystem inventory;
    public Item item1;
    public Item item2;
    public bool item1Check = false;
    public bool item2Check = false;
    [SerializeField] private string newLevel;
    [SerializeField] private string Item1Level;
    [SerializeField] private string Item2Level;


    private void Update()
    {


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Player"))
        {
            inventory = FindObjectOfType<InventorySystem>();



            if (inventory.items[0]==item1 || inventory.items[1] == item1)
            {
                item1Check = true;
            }
            if (inventory.items[0] == item2 || inventory.items[1] == item2)
            {
                item2Check = true;
            }



            if (item1Check == false && item2Check == false)
            {
                SceneManager.LoadScene(newLevel);
                return;
            }

            else if (item1Check == true && item2Check == false)
            {
                Debug.Log("Key was pressed");
                SceneManager.LoadScene(Item1Level);
                return;
            }

            else if (item2Check == true && item1Check == false)
            {
                Debug.Log("Box was pressed");

                SceneManager.LoadScene(Item2Level);
            }
            return;
        }

    }

}
