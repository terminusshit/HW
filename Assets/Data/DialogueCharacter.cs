using UnityEngine;
using TMPro;

public class DialogueCharacter : MonoBehaviour
{
    public TMP_Text dialogueText;
    public TMP_Text characterNameText;
    private CharacterName characterNameScript; 

    void Start()
    {
        characterNameScript = FindObjectOfType<CharacterName>();
        if (characterNameScript == null)
        {
            Debug.LogError("CharacterName script not found!");
            return;
        }
        
        SetCharacterDialogue(characterNameScript.GetCharacterName(), "Привет! Как дела?");
    }

    public void SetCharacterDialogue(string name, string dialogue)
    {
        if (dialogueText != null && characterNameText != null)
        {
            dialogueText.text = dialogue;
            characterNameText.text = "Name: " + name;
        }
        else
        {
            Debug.LogError("dialogueText or characterNameText is not assigned!");
        }
    }
}    