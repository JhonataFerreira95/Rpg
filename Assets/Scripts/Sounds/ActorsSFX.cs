using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorsSFX : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    public void PlaySFX(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
