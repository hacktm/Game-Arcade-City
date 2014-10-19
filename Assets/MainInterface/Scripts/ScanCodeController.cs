using UnityEngine;
using System.Collections;

public class ScanCodeController : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
			Screen.orientation = ScreenOrientation.Portrait;
		}
	
		// Update is called once per frame
		void Update ()
		{
			if (Input.GetKeyDown(KeyCode.Escape)){
				Application.LoadLevel("MainMenu");
			}
		}
}

