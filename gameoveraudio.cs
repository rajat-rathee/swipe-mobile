using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class gameoveraudio : MonoBehaviour {
    void Start() {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        
    }
}