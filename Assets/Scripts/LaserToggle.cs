using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserToggle : MonoBehaviour
{
    public GameObject laser; // Laser to toggle
    private Collider laserCollider; // Collider of the laser

    public Transform buttonTransform; // Transform of the button
    public float moveSpeed = 5f; // Speed of button movement
    public Vector3 onPosition; // Customizable position for ON state
    public Vector3 offPosition; // Customizable position for OFF state
    public AudioSource audioSource;
    void Start()
    {
        // Initialize the laser collider
        laserCollider = laser.GetComponent<Collider>();
        UpdateLaserState(laser.activeSelf);
    }

    private void OnMouseDown()
    {
        // Toggle the laser and update its state
        bool newState = !laser.activeSelf;
        PlayAudio();
        laser.SetActive(newState);
        UpdateLaserState(newState);

        // Determine the target position based on the laser's new state
        Vector3 targetPosition = laser.activeSelf ? onPosition : offPosition;

        // Smoothly move the button to the target position
        StartCoroutine(MoveButton(targetPosition));
    }

    void UpdateLaserState(bool isActive)
    {
        // Update both the visual and collider state of the laser
        laserCollider.enabled = isActive; // Enable or disable the collider
    }

    private IEnumerator MoveButton(Vector3 targetPosition)
    {
        while (Vector3.Distance(buttonTransform.localPosition, targetPosition) > 0.01f)
        {
            buttonTransform.localPosition = Vector3.Lerp(buttonTransform.localPosition, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }
    }
    public void PlayAudio()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogError("AudioSource is not assigned!");
        }
    }
}
