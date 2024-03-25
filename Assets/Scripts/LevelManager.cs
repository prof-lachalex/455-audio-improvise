using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    AudioClip[] backgroundMusics;

    AudioSource musicSource;

    // Start is called before the first frame update
    void Start()
    {
        musicSource = GameObject.Find("MusicSource").GetComponent<AudioSource>();
        if(backgroundMusics.Length > 0 && musicSource != null)
        {
            AudioClip clip = backgroundMusics[Random.Range(0, backgroundMusics.Length)];
            musicSource.clip = clip;
            musicSource.loop = true;
            musicSource.volume = AudioManager.instance.GetMusicVolume();
            musicSource.Play();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
