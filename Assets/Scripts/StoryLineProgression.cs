using UnityEngine;

public class StoryLineProgression : MonoBehaviour
{
    public GameObject key;
    public GameObject box;
    public bool keyCheck = false;
    public bool boxCheck = false;

    void Update()
    {
        if (keyCheck || boxCheck == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Destroy(key);
                Destroy(box);
            }
            return;
        }


        //Input.GetKeyDown("space") 
        //keycheck = true
        //then ......
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("key"))
        {
            Debug.Log("KEY");

            keyCheck = true;

        }
        if (other.CompareTag("box"))
        {
            Debug.Log("BOX");

            boxCheck = true;

        }
        //check if object colliding with key or box
        //destroy key
        //destroy box
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("key"))
        {
            keyCheck = false;
        }
        if (collision.CompareTag("box"))
        {
            boxCheck = false;
        }
    }
}

