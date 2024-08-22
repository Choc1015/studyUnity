using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager 
{ 

    // MP3 Player -> AudioSource 
    // MP3 À½¿ø -> AudioClip
    // °ü°´(±Í) -> AudioListener

    public void Play(Define.Sound type ,string path, float pitch = 1f)
    {
        if(type == Define.Sound.Bgm)
        {
            AudioClip audioClip = Managers.Resource.Load<AudioClip>(path);
        }
        else
        {

        }
    }
}
