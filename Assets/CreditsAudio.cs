using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsAudio : MonoBehaviour
{
    private AudioSource _audioSource;
     private void Awake()
     {
         DontDestroyOnLoad(transform.gameObject);
         _audioSource = GetComponent<AudioSource>();
     }
}
