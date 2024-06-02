using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class loadScene3 : MonoBehaviour
{
    // Public variable to set the scene name in the Inspector
    public string sceneName;

    // Reference to the VideoPlayer component
    private VideoPlayer videoPlayer;

    void Start()
    {
        // Get the VideoPlayer component attached to the same GameObject
        videoPlayer = GetComponent<VideoPlayer>();

        if (videoPlayer != null)
        {
            // Subscribe to the loopPointReached event
            videoPlayer.loopPointReached += OnVideoEnd;
        }
        else
        {
            Debug.LogError("No VideoPlayer component found on this GameObject.");
        }
    }

    // This method is called when the video ends
    void OnVideoEnd(VideoPlayer vp)
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            // Load the scene specified in the Inspector
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name is not set. Please set the scene name in the Inspector.");
        }
    }

    void OnDestroy()
    {
        // Unsubscribe from the event to avoid potential memory leaks
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached -= OnVideoEnd;
        }
    }

}
