using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private UI_Inventory uiInventory;
    public void Start()
    {
        Inventory inventory = new();
        uiInventory.SetInventory(inventory);
    }
}
