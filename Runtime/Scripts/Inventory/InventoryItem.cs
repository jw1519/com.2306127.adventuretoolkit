using System.Collections;
using System.Collections.Generic;
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
    public int amount;
    public GameObject hoverInformation;
    public TextMeshProUGUI itemInformationTextMesh;
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
        hoverInformation.SetActive(true);
        itemInformationTextMesh.SetText(itemInformation);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hoverInformation.SetActive(false);
    }
}
