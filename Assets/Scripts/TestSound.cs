    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public AudioClip _audio;
    public AudioClip _audio2;

    int i = 0;
    private void OnTriggerEnter(Collider other)
    {
        //AudioSource audio = GetComponent<AudioSource>();

        //audio.PlayOneShot(_audio);
        //audio.PlayOneShot(_audio2);

        //float lifeTime = Mathf.Max(_audio.length, _audio2.length);

        //Destroy(gameObject, lifeTime);

        i++;

        if(i % 2 == 0)
        Managers.Sound.Play(_audio, Define.Sound.Effect);
        else
        Managers.Sound.Play("UnityChan/univ0003", Define.Sound.Bgm);

    }
}
