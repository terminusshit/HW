using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public SpriteRenderer[] sprites;
    private int currentSpriteIndex = 0;

    void Start()
    {
        ShowNextSprite();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowNextSprite();
        }
    }

    void ShowNextSprite()
    {
        for (int i = 0; i < sprites.Length; i++)
        {
            sprites[i].gameObject.SetActive(i == currentSpriteIndex);
        }

        currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Length;
    }
}