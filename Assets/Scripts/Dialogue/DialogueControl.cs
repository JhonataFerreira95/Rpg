using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    [System.Serializable]
    public enum idiom
    {
        pt,
        eng,
        spa 
    }

    public idiom language;

    [Header("Components")]
    public GameObject dialogueObj; // Janela do dialogo
    public Image ProfileSprite; // sprite do perfil
    public Text speechText; // texto da fala
    public Text actorNameText; // nome npc

    // Variáveis de controle
    [Header("Settings")]
    public float typingSpeed; // velocidade da fala
    public bool isShowing; // se a janela está visível
    private int index; // index das sentenças 
    private string[] sentences;
    private string[] currentActorName;
    private Sprite[] actorSprite;

    public static DialogueControl instance;

    // awake é chamdo antes de todos os start() na hierarquia de scripts
    private void Awake()
    {
        instance = this;
    }

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

    // pular para próxima frase/fala
    public void NextSentence()
    {
        if(speechText.text == sentences[index])
        {
            if(index < sentences.Length - 1)
            {
                index++;
                ProfileSprite.sprite = actorSprite[index];
                actorNameText.text = currentActorName[index];
                speechText.text = "";
                StartCoroutine(TypeSentence());
            }
            else // Quando terminam os textos
            {
                speechText.text = "";
                actorNameText.text = "";
                index = 0;
                dialogueObj.SetActive(false);
                sentences = null;
                isShowing = false;
            }
        }
    }

    // chamar a falar do npc
    public void Speech(string[] txt, string[]actorName, Sprite[]actorProfile)
    {
        if (!isShowing)
        {
            dialogueObj.SetActive(true);
            sentences = txt;
            currentActorName = actorName;
            actorSprite = actorProfile;
            StartCoroutine(TypeSentence());
            isShowing = true;
        }              
    }
}
