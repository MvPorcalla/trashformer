using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FTUE : MonoBehaviour
{
    // script for "First-Time User Experience (FTUE)."

    // Public method to load the appropriate scene
    private void Awake()
    {
        // Check if it's the first run and Set the flag to indicate the first run
        if (!PlayerPrefs.HasKey("FirstRun") || PlayerPrefs.GetInt("FirstRun") != 1)
        {
            // Set the flag to indicate the first run
            PlayerPrefs.SetInt("FirstRun", 1);
            PlayerPrefs.Save();
            
        }
        else if(PlayerPrefs.GetInt("FirstRun") == 1)
        {
            SceneManager.LoadScene("EHomePage");
        }
    }
}