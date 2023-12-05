using UnityEngine;
using TMPro;

public class DisplayName : MonoBehaviour
{
    public TMP_Text nameText; // Ссылка на компонент TextMeshPro

    void Start()
    {
        // Пример установки имени при старте
        SetName("Alice");
    }

    public void SetName(string characterName)
    {
       
        nameText.text =  characterName;
    }
}