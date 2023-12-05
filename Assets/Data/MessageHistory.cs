/* using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MessageHistory : MonoBehaviour
{
    public Text messageText; // UI Text для отображения сообщений
    private string[] messages; // Массив сообщений
    private int currentMessageIndex; // Индекс текущего сообщения

    void Start()
    {
        messages = new string[]
        {
            "Эй, слышала, ты планируешь покорить мир йоги?",
            "О да, я уже философию мантры 'Ом' освоила!",
            "Вот только моя йога больше напоминает 'кошачью драку' с ковриком.",
            "А я вот пыталась выполнить позу 'свечи'. Теперь у меня подозрительное желание к ночным небесам всегда с лампочкой в руках!",
            "Ого, это уже звучит как креативная идея для освещения вечеринок!",
            "Да, теперь я готова 'осветить' все свои тайные уголки."
        };

        currentMessageIndex = 0;
        ShowNextMessage();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShowNextMessage();
        }
    }

    void ShowNextMessage()
    {
        if (currentMessageIndex < messages.Length)
        {
            messageText.text = messages[currentMessageIndex];
            currentMessageIndex++;
        }
        else
        {
            Debug.Log("Конец истории сообщений.");
        }
    }
} */