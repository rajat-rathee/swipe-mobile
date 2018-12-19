using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class highscorescript : MonoBehaviour {
	int highscore;
	
	Text text; 

	void Awake() {
		text = GetComponent <Text> ();
	}
	
 
 void Start(){
         highscore = PlayerPrefs.GetInt("HighScore",0);


 }


    void Update ()
    {
    	highscore = PlayerPrefs.GetInt("HighScore",0);
    	if(ScoreChanger.score > highscore)
           PlayerPrefs.SetInt("HighScore",ScoreChanger.score);

           text.text = "" + highscore;
           Debug.Log(highscore);

    	
    	
    } 
 }

