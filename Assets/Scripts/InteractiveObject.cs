using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    [SerializeField]
    GameObject messageCanvas;

    void Start()
    {
        
        messageCanvas.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Replacment of person")
        {
            TurnOnMessage();
        }
    }

    private void TurnOnMessage()
    {
        messageCanvas.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Replacment of person")
        {
            TurnOffMessage();
        }
    }

    private void TurnOffMessage()
    {
        messageCanvas.SetActive(false);
    }
}
