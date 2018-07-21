using UnityEngine;
using System.Collections;

public class shopaudio : MonoBehaviour {
	public AudioClip point;
	private AudioSource source;
	private float volLowRange = .9f;
    private float volHighRange = 1.0f;

    void Awake () {
    
        source = GetComponent<AudioSource>();

    }
	

	void OnMouseDown () {
		float vol = Random.Range (volLowRange, volHighRange);
		source.PlayOneShot(point,vol);
		Application.LoadLevel(2);

	}
}
