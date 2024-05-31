using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string gameSceneName = "Basement"; // Name of your game scene
    public string creditsSceneName = "Credits"; // Name of your credits scene
    public string instructionsSceneName = "Instructions"; // Name of your instructions scene

    // Method to load the game scene
    public void StartNewGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    // Method to show credits
    public void ShowCredits()
    {
        SceneManager.LoadScene(creditsSceneName);
    }

    // Method to show instructions
    public void ShowInstructions()
    {
        SceneManager.LoadScene(instructionsSceneName);
    }

    // Method to exit the game
    public void ExitGame()
    {
        Debug.Log("Exit button clicked"); // Debug log to confirm the button was clicked
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
}
