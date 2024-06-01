using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class L1NextTransition : MonoBehaviour
{
    // Method to load the next level
    public void LoadNextLevel()
    {
        SceneManager.LoadScene("level2Scene");
    }

    // Method to load the main menu
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
