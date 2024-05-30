using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Money : MonoBehaviour, IPointerClickHandler
{
    private LevelManager levelManager;

    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Ensure the eventData is not null and we clicked with the left mouse button.
        if (eventData != null && eventData.button == PointerEventData.InputButton.Left)
        {
            // Try to get the PlayerInventory component from the player
            PlayerInventory playerInventory = FindObjectOfType<PlayerInventory>();
            if (playerInventory != null)
            {
                playerInventory.MoneyCollected();
                gameObject.SetActive(false);

                if (levelManager != null)
                {
                    levelManager.CollectMoneyBag();
                }
            }
        }
    }
}
