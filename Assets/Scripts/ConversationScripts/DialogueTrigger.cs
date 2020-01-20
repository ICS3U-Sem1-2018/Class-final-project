using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    public bool button = false;
    public bool input = false;


    private void Update()
    {
        if(button == true)
        {
            if (Input.GetKeyDown("space"))
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

            }
        }
    }
    public void TriggerDialogue()
    {

        if (input == true)
        {
           
        }



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("It be pressed");
            input = true;
            button = true;
            
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("box"))
        {
            input = false;
            button = false;
        }

    }

}
