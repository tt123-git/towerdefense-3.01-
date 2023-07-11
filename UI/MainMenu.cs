using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public string levelToLoad = "Stage1";

    public SceneFader sceneFader;
    public void Play()
    {
        FindObjectOfType<SceneFader>().FadeTo(levelToLoad);
    }   
    
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
