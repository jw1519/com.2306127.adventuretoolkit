using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButtons : MonoBehaviour
{
    public GameObject inventory;
    public GameObject inventoryButton;
    public GameObject closeButton;
    public void OpeningInventory()
    {
        inventory.SetActive(true);
        inventoryButton.SetActive(false);
        closeButton.SetActive(true);
    }
    public void CloseInventory()
    {
        inventory.SetActive(false);
        inventoryButton.SetActive(true);
        closeButton.SetActive(false);
    }
}
