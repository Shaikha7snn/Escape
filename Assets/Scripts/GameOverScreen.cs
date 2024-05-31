using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    private static string previousScene;

    // Method to be called before loading the game over screen
    public static void SetPreviousScene(string sceneName)
    {
        previousScene = sceneName;
    }

    // Method to restart the previous level
    public void TryAgain()
    {
        if (!string.IsNullOrEmpty(previousScene))
        {
            SceneManager.LoadScene(previousScene);
        }
        else
        {
            Debug.LogWarning("Previous scene not set.");
        }
    }

    // Method to go back to the main menu
    public void MainMenu()
    {
        // Load the main menu scene
        SceneManager.LoadScene("MainMenu"); // Replace with your actual main menu scene name
    }
}
