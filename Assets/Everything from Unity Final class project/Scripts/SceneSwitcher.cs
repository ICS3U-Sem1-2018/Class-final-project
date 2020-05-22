using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField] private string newLevel;
    [SerializeField] private string next;


    public void GotoMainScene()
    {
        SceneManager.LoadScene(newLevel);
        return;
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene(next);
        return;
    }
}

