using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	public static int score;	
	public static int life;

	// Use this for initialization
	void Start ()
	{
		score = 0;
		life = 100;
	}
	void OnGUI() {
		GUI.TextArea(new Rect(70, Screen.height/2 + 10, 75, 40), "Life: "+life+"\nScore: "+score);
		GUI.TextArea(new Rect(70+Screen.width/2, Screen.height/2 + 10, 75,  40), "Life: "+life+"\nScore: "+score);
	}
	// Update is called once per frame
	void Update ()
	{
		if (life <= 0){
			// go to end game;
		}
	}
}

