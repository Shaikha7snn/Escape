using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    // Method to restart the current level
    public void TryAgain()
    {
        // Reload the current active scene
        SceneManager.LoadScene("Level 4");
    }

    // Method to go back to the main menu
    public void MainMenu()
    {
        // Load the main menu scene
        SceneManager.LoadScene("MainMenu"); // Replace with your actual main menu scene name
    }
}
