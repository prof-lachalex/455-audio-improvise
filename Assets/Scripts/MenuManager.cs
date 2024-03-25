using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    [SerializeField]
    AudioClip testSound;

    AudioSource soundSource;
    AudioSource musicSource;

    TextMeshProUGUI musicValueText;
    Slider musicSlider;

    // Start is called before the first frame update
    void Start()
    {
        soundSource = GameObject.Find("SoundSource").GetComponent<AudioSource>();
        musicSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        musicValueText = GameObject.Find("MusicValue").GetComponent <TextMeshProUGUI>();
        musicSlider = GameObject.Find("MusicSlider").GetComponent<Slider>();

        OnMusicSliderChange();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTestSoundButton()
    {
        
        if (soundSource != null)
        {
            soundSource.PlayOneShot(testSound);
        }
    }

    public void OnMusicSliderChange()
    {
        musicValueText.text = Mathf.CeilToInt(musicSlider.value * 100).ToString();
        musicSource.volume = musicSlider.value;
        AudioManager.instance.SetMusicVolume(musicSlider.value);
    }

    public void OnPlayButton()
    {
        SceneManager.LoadScene("GameScene");
    }
}
