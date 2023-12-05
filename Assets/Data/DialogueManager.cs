using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text dialogueText;
    public TMP_Text characterNameText;
    public string[] characterNames;
    public string[] dialogues;

    private int currentDialogueIndex = 0;

    void Start()
    {
        ShowNextDialogue();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowNextDialogue();
        }
    }

    void ShowNextDialogue()
    {
        if (currentDialogueIndex < dialogues.Length)
        {
            characterNameText.text = characterNames[currentDialogueIndex]; 
            dialogueText.text = dialogues[currentDialogueIndex]; 
            currentDialogueIndex++;
        }
    }
}