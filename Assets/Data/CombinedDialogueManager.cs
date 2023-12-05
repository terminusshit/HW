using UnityEngine;
using TMPro;
using System.Collections;

public class CombinedDialogueManager : MonoBehaviour

{
    public TMP_Text dialogueText;
    public SpriteRenderer characterSpriteRenderer;
    public Sprite newCharacterSprite;
    private string[] dialogues;
    private int currentDialogueIndex;
    public float typingSpeed = 0.05f; 

    private string fullText;
    private bool isTyping = false;

    void Start()
    {
        dialogues = new string[]
        {
            "Эй, слышала, ты планируешь покорить мир йоги?",
            
            "О да, я уже философию мантры 'Ом' освоила!",
            
            "Вот только моя йога больше напоминает 'кошачью драку' с ковриком.",
            
            "А я вот пыталась выполнить позу 'свечи'. Теперь у меня подозрительное желание к ночным небесам всегда с лампочкой в руках!",
            
            "Ого, это уже звучит как креативная идея для освещения вечеринок!",
            
            "Да, теперь я готова 'осветить' все свои тайные уголки."
        };
        
        currentDialogueIndex = 0;
        ShowCurrentDialogue();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isTyping)
            {
                StopCoroutine("ShowTextWithDelay");
                dialogueText.text = fullText;
                isTyping = false;
            }
            else if (currentDialogueIndex < dialogues.Length - 1)
            {
                currentDialogueIndex++;
                ShowCurrentDialogue();
            }
            else
            {
                EndDialogue();
            }
        }
    }

    void ShowCurrentDialogue()
    {
        fullText = dialogues[currentDialogueIndex];

        dialogueText.text = string.Empty;
        StartCoroutine(ShowTextWithDelay());
    }

    IEnumerator ShowTextWithDelay()
    {
        isTyping = true;
        for (int i = 0; i <= fullText.Length; i++)
        {
            dialogueText.text = fullText.Substring(0, i);
            yield return new WaitForSeconds(typingSpeed);
        }
        isTyping = false;

        RectTransform rectTransform = dialogueText.GetComponent<RectTransform>();
        Vector2 baseSize = new Vector2(dialogueText.preferredWidth, dialogueText.preferredHeight);
    }

    void EndDialogue()
    {
        Debug.Log("Диалог завершен!");
    }
    
    void ChangeCharacterSprite()
    {
        // Меняем спрайт персонажа после завершения первого диалога
        characterSpriteRenderer.sprite = newCharacterSprite;
    }
}
