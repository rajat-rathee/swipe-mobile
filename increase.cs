using UnityEngine;
using System.Collections;

public class increase : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (ScoreChanger.score == 5) 
    Spawner.spawnFrequency = 3f;
    Debug.Log(Spawner.spawnFrequency);
    if (ScoreChanger.score == 10)
    Spawner.spawnFrequency = 2.5f;
    Debug.Log(Spawner.spawnFrequency);
    if (ScoreChanger.score == 20) 
    Spawner.spawnFrequency = 2f;
    Debug.Log(Spawner.spawnFrequency);
    if (ScoreChanger.score == 30) 
    Spawner.spawnFrequency = 1.8f;
    Debug.Log(Spawner.spawnFrequency);
    if (ScoreChanger.score == 45) 
    Spawner.spawnFrequency = 1.4f;
    Debug.Log(Spawner.spawnFrequency);
      
	
	}
}
