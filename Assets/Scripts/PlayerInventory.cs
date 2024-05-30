using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfMoney { get; private set; }

    public UnityEvent<PlayerInventory> OnMoneyCollected;

    public void MoneyCollected()
    {
        NumberOfMoney = NumberOfMoney + 100;
        OnMoneyCollected.Invoke(this);
    }
}
