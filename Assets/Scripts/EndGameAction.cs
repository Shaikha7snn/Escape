using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameAction : Action
{
    public override TaskStatus OnUpdate()
    {
        // Implement your game-over logic here
        Debug.Log("Player detected! Game Over.");

        // Example: Load a game-over scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        // Alternatively, you can stop the game entirely
        // Application.Quit();

        // Return success to indicate that the action has been completed
        return TaskStatus.Success;
    }
}
