/* using UnityEngine;
using TMPro;

public class DialogueDisplay : MonoBehaviour
{
    public TMP_Text dialogueText;

    void Start()
    {
        CombinedDialogueManager dialogueScript = FindObjectOfType<CombinedDialogueManager>();

        if (dialogueScript != null)
        {
            string dialogue = dialogueScript.Start();
            DisplayDialogue(dialogue);
        }
        else
        {
            Debug.LogError("DialogueScript not found!");
        }
    }

    void DisplayDialogue(string dialogue)
    {
        dialogueText.text = dialogue;
    }
} */