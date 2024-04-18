using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour
{
    public string scenename;

    public int NumberOfMoney { get; private set; }

    public UnityEvent<Inventory> OnMoneyCollected;

    public void MoneyCollected()
    {
        NumberOfMoney++;
        OnMoneyCollected.Invoke(this);
    }

    void Update()
    {
        if (NumberOfMoney >= 5)
        {
            SceneManager.LoadScene(scenename);
        }
    }
}
