using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets instance;

    private void Awake()
    {
        instance = this;
    }

    public Sprite swordSprite;
    public Sprite healthPotionSprite;
    public Sprite goldSprite;
}
