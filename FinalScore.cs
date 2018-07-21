using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinalScore: MonoBehaviour
{
    public static int score2;        // The player's score.


    Text text;                      // Reference to the Text component.


    void Awake ()
    {
        // Set up the reference.
        text = GetComponent <Text> ();

        // Reset the score.
        score2 = 0;
    }


    void Update ()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "" + score2;
    }
}