using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGames(){
		Debug.Log("ON GAMES");
		Application.LoadLevel("GamesScene");
	}

	public void OnScanCode(){
		Debug.Log("ON SCAN CODE");
	}
}
