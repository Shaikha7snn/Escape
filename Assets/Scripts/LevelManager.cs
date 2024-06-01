using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int totalMoneyBags = 5; // Total money bags to collect
    private int collectedMoneyBags = 0;
    private bool levelCompleted = false;

    public Timer timer; // Reference to the Timer script

    void Start()
    {
        timer.SetDuration(60).Begin(); // Set the duration to 1 minute
        timer.OnTimerEnd.AddListener(OnTimerEnd);
    }

    public void CollectMoneyBag()
    {
        collectedMoneyBags++;
        if (collectedMoneyBags >= totalMoneyBags)
        {
            levelCompleted = true;
            Debug.Log("YOU WIN!");
            LoadWinScene();
        }
    }

    private void OnTimerEnd()
    {
        if (!levelCompleted)
        {
            LoadGameOverScene();
        }
    }

    private void LoadGameOverScene()
    {
        GameOverScreen.SetPreviousScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("LoseScreen"); // Replace with your actual game over scene name
    }

    private void LoadWinScene()
    {
        SceneManager.LoadScene("4End"); // Load the win scene directly
    }
}
