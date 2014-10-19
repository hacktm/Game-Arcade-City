using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GamesController : MonoBehaviour {

	public Button Runner;

	public Button Shooter;

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.Portrait;

		Runner.interactable = isGameActivated("Runner");

		Shooter.interactable = isGameActivated("Shooter");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.LoadLevel("MainMenu");
		}
	}

	bool isGameActivated(string name){
	
		int value = PlayerPrefs.GetInt(name, 0);

		return value != 0;
	}

	public void OnStartGame(string levelName){
		Screen.orientation = ScreenOrientation.Landscape;
		Application.LoadLevel(levelName);
	}
}
