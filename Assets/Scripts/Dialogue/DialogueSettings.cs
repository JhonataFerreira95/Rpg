using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "New Dialogue/Dialogue")]
public class NewBehaviourScript : ScriptableObject
{
    [Header("Settings")]
    public GameObject actor;

    [Header("Dialogue")]
    public Sprite speakSprite;
    public string sentence;

}

public class Sentences
{
    public string actorName;
    public Sprite profile;
    public Langueges sentence;
}

public class Langueges
{
    public string portuguese;
    public string english;
    public string spanish;
}
