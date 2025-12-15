using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogueObj; // Janela do dialogo
    public Image ProfileSprite; // sprite do perfil
    public Text speechText; // texto da fala
    public Text actorNameText; // nome npc

    [Header("Settings")]
    public float typingSpeed; // velocidade da fala

    // Variáveis de controle

    private bool isShowing; // se a janela está visível
    private int index; // index das sentenças 
    private string[] sentences;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    IEnumerator TypeSentence()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }  
    }
}
