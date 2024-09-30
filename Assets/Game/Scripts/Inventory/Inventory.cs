using System;
using System.Collections.Generic;
using Game.Scripts.Extra;
using UnityEngine;

public class Inventory : Singelton<Inventory>
{

    [Header("Config")]
    [SerializeField] private int InventorySize;

    [SerializeField] private InventoryItem[] _inventoryItems;
    public int inventorySize => InventorySize;


    public void Start()
    {
        _inventoryItems = new InventoryItem[InventorySize];
    }

    private void AddItemFreeSlot(InventoryItem item, int quantity)
    {
    }

    private List<int> CheckItemStock(string itemID)
    {
        List<int> itemIndex = new List<int>();
        for (int i = 0; i < _inventoryItems.Length; i++)
        {

            if (_inventoryItems[i]==null) continue;
            if (_inventoryItems[i].ID == itemID)
            {
                itemIndex.Add(i);
            }
            
        }

        return itemIndex;
    }
}
