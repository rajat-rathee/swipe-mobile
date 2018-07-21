using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class replaybutton : MonoBehaviour {

	public void ChagneScene (int numb) {
		AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
		Application.LoadLevel(numb);
	}
}
