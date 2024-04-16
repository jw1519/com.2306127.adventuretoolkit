using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public enum ItemType //declare the items
    {
        Sword,
        HealthPotion,
        Gold,
        QuestItem,
    }

    public ItemType itemType;
    public int Amount;
    public GameObject HoverInformation;
    public TextMeshProUGUI ItemInformationTextMesh;

    public string itemInformation;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Sword:        return ItemAssets.instance.swordSprite;
            case ItemType.HealthPotion: return ItemAssets.instance.healthPotionSprite;
            case ItemType.Gold:         return ItemAssets.instance.goldSprite;
        }
    }

    public void OnPointerEnter(PointerEventData eventData) //when mouse hover over
    {
        
        HoverInformation.SetActive(true);
        ItemInformationTextMesh.SetText(itemInformation);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverInformation.SetActive(false);
    }
}
