using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class KeyDoor : MonoBehaviour
{
    public Animator openandclose;
    public bool isOpen;
    public Transform player;
    public float interactionDistance = 15.0f;
    public string endSceneName;
    public TextMeshProUGUI keyMessage;

    void Start()
    {
        isOpen = false;
        keyMessage.gameObject.SetActive(false);
    }

    void Update()
    {
        HandleDoorInteraction();
    }

    void HandleDoorInteraction()
    {
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist <= interactionDistance && Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform &&  hit.transform.gameObject.layer == LayerMask.NameToLayer("ExitDoorLayer"))
                {
                    if (!isOpen && KeyPickup.HasKey)
                    {
                        StartCoroutine(Opening());
                    }
                    else if (isOpen)
                    {
                        StartCoroutine(Closing());
                    }
                    else if (!KeyPickup.HasKey)
                    {
                        StartCoroutine(DisplayMessage("You have to find the key to open the door."));
                    }
                }
            }
        }
    }

    IEnumerator Opening()
    {
        openandclose.Play("Opening");
        isOpen = true;
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(endSceneName);
    }

    IEnumerator Closing()
    {
        openandclose.Play("Closing");
        isOpen = false;
        yield return new WaitForSeconds(0.5f);
    }

    IEnumerator DisplayMessage(string message)
    {
        keyMessage.text = message;
        keyMessage.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        keyMessage.gameObject.SetActive(false);
    }
}
