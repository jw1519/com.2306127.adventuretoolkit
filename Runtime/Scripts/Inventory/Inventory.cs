using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<InventoryItem> itemList;

    public Inventory()
    {
        itemList = new List<InventoryItem>();

        AddItem(new InventoryItem { itemType = InventoryItem.ItemType.Sword, amount = 1 });
        AddItem(new InventoryItem { itemType = InventoryItem.ItemType.HealthPotion, amount = 1 });
        AddItem(new InventoryItem { itemType = InventoryItem.ItemType.Gold, amount = 100 });
        Debug.Log(itemList.Count);
    }
    public void AddItem(InventoryItem item)
    {
        itemList.Add(item);
    }

    public List<InventoryItem> GetItemList()
    {
        return itemList;
    }
    
}
