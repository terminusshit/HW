using UnityEngine;
using TMPro;

public class DialogueSpriteManager : MonoBehaviour
{
    public TMP_Text dialogueText;
    public SpriteRenderer[] sprites;
    public string[] dialogues;

    private int currentDialogueIndex = 0;
    private bool textDisplayed = false;

    void Update()
    {
        if (!textDisplayed && Input.GetKeyDown(KeyCode.Space))
        {
            DisplayFullDialogue();
        }
        else if (textDisplayed && Input.GetKeyDown(KeyCode.Space))
        {
            ShowNextSprite();
        }
    }

    void DisplayFullDialogue()
    {
        if (currentDialogueIndex < dialogues.Length)
        {
            dialogueText.text = dialogues[currentDialogueIndex];
            textDisplayed = true;
        }
    }

    void ShowNextSprite()
    {
        if (currentDialogueIndex < dialogues.Length - 1)
        {
            currentDialogueIndex++;
            dialogueText.text = ""; // Очищаем текст
            textDisplayed = false;

            for (int i = 0; i < sprites.Length; i++)
            {
                sprites[i].gameObject.SetActive(i == currentDialogueIndex); // Отображаем только текущий спрайт
            }
        }
    }
}