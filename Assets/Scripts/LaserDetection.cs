using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LaserDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Make sure your player GameObject has the tag "Player"
        {
            Debug.Log("Player has touched a laser. Showing game over screen.");
            GameOverScreen.SetPreviousScene(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("LoseScreen");  // Replace with your actual game over scene name
        }
    }
}
