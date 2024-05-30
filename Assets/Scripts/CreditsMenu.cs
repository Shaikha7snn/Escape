using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsMenu : MonoBehaviour
{
   // public string mainMenuSceneName = "MainMenu"; // Name of your main menu scene

    // Method to return to main menu
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(3);
    }
}
