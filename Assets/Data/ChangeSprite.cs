using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public Sprite newSprite; 

    void ChangeCharacterSprite()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null && newSprite != null)
        {
            spriteRenderer.sprite = newSprite; 
        }    
    }
}

