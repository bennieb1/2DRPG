using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
   [SerializeField] private Image itemIcon;
   [SerializeField] private Image quantityImage;
   [SerializeField] private TextMeshProUGUI itemQuantityTMP;

   public int Index { get; set; }

   public void UpdateSlot(InventoryItem item)
   {

      itemIcon.sprite = item.Icon;
      itemQuantityTMP.text = item.Quantity.ToString();

   }

   public void ShowSlotInfo(bool value)
   {
      
      itemIcon.gameObject.SetActive(value);
      quantityImage.gameObject.SetActive(value);
      
   }
}
