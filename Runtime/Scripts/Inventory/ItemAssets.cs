using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public Sprite swordSprite;
    public Sprite healthPotionSprite;
    public Sprite goldSprite;

    public static ItemAssets instance;
    private void Awake()
    {
        instance = this;
    }
}
