using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameAction : Action
{
    public string gameOverSceneName = "LoseScreen"; // Name of the game over scene

    public override TaskStatus OnUpdate()
    {
        // Implement your game-over logic here
        Debug.Log("Player detected! Game Over.");

        // Set the previous scene before loading the game-over scene
        GameOverScreen.SetPreviousScene(SceneManager.GetActiveScene().name);

        // Load the game-over scene
        SceneManager.LoadScene(gameOverSceneName);

        // Return success to indicate that the action has been completed
        return TaskStatus.Success;
    }
}
