using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class L2KeyDoor : MonoBehaviour
{
    public Animator openandclose;
    public bool isOpen;
    public Transform player;
    public float interactionDistance = 15.0f;
    public string endSceneName;
    public TextMeshProUGUI l2KeyMessage;

    void Start()
    {
        isOpen = false;
        l2KeyMessage.gameObject.SetActive(false);
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
                if (hit.transform == transform && hit.transform.gameObject.layer == LayerMask.NameToLayer("L2ExitDoorLayer"))
                {
                    if (!isOpen && L2KeyPickup.l2HasKey)
                    {
                        StartCoroutine(Opening());
                    }
                    else if (isOpen)
                    {
                        StartCoroutine(Closing());
                    }
                    else if (!L2KeyPickup.l2HasKey)
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
        l2KeyMessage.text = message;
        l2KeyMessage.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        l2KeyMessage.gameObject.SetActive(false);
    }
}
