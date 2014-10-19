using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.Portrait;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
	}

	public void OnGames(){
		Debug.Log("ON GAMES");
		Application.LoadLevel("GamesScene");
	}

	public void OnScanCode(){
		Debug.Log("ON SCAN CODE");
		Application.LoadLevel("ScanCode");
	}
}
