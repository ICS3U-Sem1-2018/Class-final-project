using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfChapter : MonoBehaviour
{
    [SerializeField] private string newLevel;
    public bool itemCheck = false;

    private void Update()
    {
        if (itemCheck == true)
        {
            if (Input.GetKeyDown("space"))
            {

                SceneManager.LoadScene(newLevel);

            }

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("player found");
            itemCheck = true;
        }
        return;
    }
   

    
}