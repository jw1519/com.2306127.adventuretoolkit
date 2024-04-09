using UnityEngine;

public class Player : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;
    public void Start()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }
}
