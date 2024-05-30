using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDoorController : MonoBehaviour
{
    private bool isOpen = false;
    //public Vector3 openPosition;  // The position when the door is open
    //public Vector3 closedPosition;  // The position when the door is closed
    public float speed = 2f;  // How fast the door opens or closes
    public Vector3 closedPosition;
    public Vector3 openPosition = new Vector3(1, 0, 0); // Example for sliding right by 1 unit

    void Update()
    {
        Vector3 targetPosition = isOpen ? openPosition : closedPosition;
        transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * speed);
    }

    private void OnMouseDown()
    {
        if (Vector3.Distance(Camera.main.transform.position, transform.position) < 5f)  // Make sure the player is close enough to interact
        {
            isOpen = !isOpen;  // Toggle the door state
        }
    }

    //private void OnMouseDown()
    //{
    //    Destroy(gameObject); // This destroys the door GameObject when clicked
    //}

    //public Vector3 closedPosition = new Vector3(0.1616f, 0.343f, 0.0721f);
    //public Quaternion closedRotation = Quaternion.Euler(-90, 90, 0);

    ////public Vector3 closedPosition;
    ////public Quaternion closedRotation;
    //public Vector3 openPosition;
    //public Quaternion openRotation;
    //public float speed = 2f;
    //private bool isOpen = false;

    //void Update()
    //{
    //    if (isOpen)
    //    {
    //        transform.localPosition = Vector3.Lerp(transform.localPosition, openPosition, Time.deltaTime * speed);
    //        transform.localRotation = Quaternion.Lerp(transform.localRotation, openRotation, Time.deltaTime * speed);
    //    }
    //    else
    //    {
    //        transform.localPosition = Vector3.Lerp(transform.localPosition, closedPosition, Time.deltaTime * speed);
    //        transform.localRotation = Quaternion.Lerp(transform.localRotation, closedRotation, Time.deltaTime * speed);
    //    }
    //}

    //private void OnMouseDown()
    //{
    //    if (Vector3.Distance(Camera.main.transform.position, transform.position) < 5f)
    //    {
    //        isOpen = !isOpen;
    //    }
    //}

}
