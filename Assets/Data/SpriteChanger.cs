using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite sprite1; // Первый спрайт
    public Sprite sprite2; // Второй спрайт

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Получаем компонент SpriteRenderer, прикрепленный к этому объекту
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Проверяем, что компонент SpriteRenderer был найден
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer не найден на объекте!");
        }
        else
        {
            // Если спрайт на spriteRenderer пустой, устанавливаем спрайт на spriteRenderer в sprite1
            if (spriteRenderer.sprite == null)
            {
                spriteRenderer.sprite = sprite1;
            }
        }
    }

    void Update()
    {
        // Если нажата клавиша Space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Вызываем метод для смены спрайта
            ChangeTheDamnSprite();
        }
    }

    void ChangeTheDamnSprite()
    {
        // Проверяем, что оба спрайта не пустые, иначе не имеет смысла менять
        if (sprite1 != null && sprite2 != null)
        {
            // Если текущий спрайт spriteRenderer - sprite1, то меняем на sprite2
            if (spriteRenderer.sprite == sprite1)
            {
                spriteRenderer.sprite = sprite2;
            }
            else // В противном случае меняем на sprite1
            {
                spriteRenderer.sprite = sprite1;
            }
        }
        else
        {
            Debug.LogError("Один или оба спрайта не установлены!");
        }
    }
}