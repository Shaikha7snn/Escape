using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndL4NextTransition : MonoBehaviour
{
    // Time in seconds before the transition occurs
    public float delayBeforeTransition = 5f; // Adjust this to fit your needs

    void Start()
    {
        // Start the transition after the specified delay
        Invoke("LoadNextLevelScene", delayBeforeTransition);
    }

    void LoadNextLevelScene()
    {
        SceneManager.LoadScene("L4NextScene");
    }
}
