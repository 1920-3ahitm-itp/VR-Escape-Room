using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Load : MonoBehaviour
{

    public AudioMixer mixer;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("volume"))
        {
            mixer.SetFloat("MusicVol", 0.05F);
        }
    }
}
