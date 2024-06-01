using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level3ExitDoor : MonoBehaviour
{
    public Animator openandclose;
    public bool isOpen;  // To track the state of the door
    public Transform player;
    public float interactionDistance = 15.0f;  // Maximum distance at which the player can interact with the door
    public string endSceneName = "3End";  // Name of the end scene to load

    void Start()
    {
        isOpen = false;
    }

    void Update()
    {
        HandleDoorInteraction();
    }

    void HandleDoorInteraction()
    {
        // Check if the player is within the interaction distance
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= interactionDistance)
        {
            if (Input.GetMouseButtonDown(0))  // Check for mouse input to interact with the door
            {
                if (!isOpen)  // If door is not open
                {
                    StartCoroutine(Opening());
                }
                else if (isOpen)  // If door is already open and player clicks
                {
                    StartCoroutine(Closing());
                }
            }
        }
    }

    IEnumerator Opening()
    {
        print("You are opening the door.");
        openandclose.Play("Opening");
        isOpen = true;
        yield return new WaitForSeconds(0.0f);  // Wait for half a second

        // Load the end scene
        SceneManager.LoadScene(endSceneName);  // Use the endSceneName variable
    }

    IEnumerator Closing()
    {
        print("You are closing the door.");
        openandclose.Play("Closing");
        isOpen = false;
        yield return new WaitForSeconds(0.0f);  // Wait for half a second
    }
}
