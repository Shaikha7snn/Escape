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
            Debug.Log("Player has touched a laser. Reloading scene.");
            Debug.Log("Player has touched a laser. Reloading scene.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Reload the current scene
        }
    }
}
