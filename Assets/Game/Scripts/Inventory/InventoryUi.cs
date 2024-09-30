using System;
using System.Collections.Generic;
using Game.Scripts.Extra;
using UnityEngine;

public class InventoryUi : Singelton<InventoryUi>
{
   [SerializeField] private InventorySlot slotPrefab;
   [SerializeField] private Transform container;

   private List<InventorySlot> slotList = new List<InventorySlot>();

   private void Start()
   {
      InitInventory();
   }

   private void InitInventory()
   {

      for (int i = 0; i < Inventory.Instance.inventorySize; i++)
      {
         InventorySlot slot = Instantiate(slotPrefab, container);
         slot.Index = i;
         slotList.Add(slot);
      }
      
   }

   public void DrawItem(InventoryItem item, int index)
   {
      InventorySlot slot = slotList[index];
      slot.ShowSlotInfo(true);
      slot.UpdateSlot(item);
   }
}
