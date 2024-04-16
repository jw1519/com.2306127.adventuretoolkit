using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<InventoryItem> itemList;

    public Inventory()
    {
        itemList = new List<InventoryItem>();

        AddItem(new InventoryItem { itemType = InventoryItem.Item.Sword, Amount = 1 });
        AddItem(new InventoryItem { itemType = InventoryItem.Item.HealthPotion, Amount = 1 });
        AddItem(new InventoryItem { itemType = InventoryItem.Item.Gold, Amount = 100 });
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
