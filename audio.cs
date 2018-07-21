﻿using UnityEngine;
using System.Collections;

public class audio : MonoBehaviour {

	public AudioClip point;
	private AudioSource source;
	private float volLowRange = .5f;
    private float volHighRange = 1.0f;

	void Awake () {
    
        source = GetComponent<AudioSource>();

    }
	

	void OnCollisionEnter2D(Collision2D col) {
		float vol = Random.Range (volLowRange, volHighRange); 
		if (col.gameObject.tag == "Green" )
		
		source.PlayOneShot(point,vol);


}
}
