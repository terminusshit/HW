using UnityEngine;

public class HideSpriteUntilNeeded : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false; 
    }

    void ShowSpriteWhenNeeded()
    {
        spriteRenderer.enabled = true;
    }
}