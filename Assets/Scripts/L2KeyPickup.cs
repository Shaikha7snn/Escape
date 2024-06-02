using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2KeyPickup : MonoBehaviour
{
    public static bool l2HasKey { get; private set; } = false;  // Static property to track key possession

    void OnMouseOver()
    {
        // Check if the mouse button is pressed while the cursor is over the key
        if (Input.GetMouseButtonDown(0)) // 0 is the left mouse button
        {
            l2HasKey = true;
            Destroy(gameObject);  // Remove the key from the scene
            Debug.Log("Key has been picked up.");
        }
    }
}
