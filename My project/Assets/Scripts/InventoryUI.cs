using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI moneysText;
    // Start is called before the first frame update
    void Start()
    {
        moneysText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText(Inventory inventory)
    {
        moneysText.text = inventory.NumberOfMoney.ToString();
    }
}
