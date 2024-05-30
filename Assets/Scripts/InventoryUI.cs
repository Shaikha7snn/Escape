using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI moneyText;
    // Start is called before the first frame update
    void Start()
    {
        moneyText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateMoneyText(PlayerInventory playerInventory)
    {
        moneyText.text = playerInventory.NumberOfMoney.ToString();
    }
}
