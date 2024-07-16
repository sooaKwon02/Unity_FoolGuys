using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    
    AudioSource audioSource;
    public AudioClip[] audioClips;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();       
        PlayClip();
    }
            
    void PlayClip()
    {
        audioSource.clip=audioClips[(ScenesManager.SceneNum)-1];
        audioSource.Play();
    }

    public void SoundMute()
    {

    }
        
        
  

}
