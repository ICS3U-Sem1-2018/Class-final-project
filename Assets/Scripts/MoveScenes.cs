using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScenes : MonoBehaviour
{
    private InventorySystem inventory;
    public Item item1;
    public Item item2;
    [SerializeField] private string newLevel;
    [SerializeField] private string Item1Level;
    [SerializeField] private string Item2Level;


    private void Update()
    {


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(newLevel);

            inventory = FindObjectOfType<InventorySystem>();

            if (item1 == true)
            {
                SceneManager.LoadScene(Item1Level);
            }

            else if (item2 == true)
            {
                SceneManager.LoadScene(Item2Level);
            }
            return;
        }
        
    }

}
