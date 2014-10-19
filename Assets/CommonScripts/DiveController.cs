using UnityEngine;
using System.Collections;

public class DiveController : MonoBehaviour {

	public static OpenDiveSensor DiveSensor;

	public OpenDiveSensor CurrentDiveSensor;

	public WebCamTexture CameraTexture;

	public int WebCameraSizeDivider = 2;
	// Use this for initialization
	void Start () {
		DiveSensor = CurrentDiveSensor;
		Initialize();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("Rotation: "+DiveSensor.transform.eulerAngles);
	}

	void OnCardboardTrigger()
	{
		Debug.Log("CARDBOARD TRIGGERED");
	}

	public void Initialize(){
		Debug.Log("Initialize");
		GUITexture BackgroundTexture = gameObject.AddComponent<GUITexture>();
		int textureSizeX = Screen.width / WebCameraSizeDivider;
		int textureSizeY = Screen.height / WebCameraSizeDivider;
		BackgroundTexture.pixelInset = new Rect(0,0,textureSizeX, textureSizeY);
		//BackgroundTexture.transform.localScale = new Vector3(WebCameraSizeDivider, WebCameraSizeDivider, 1);
		//set up camera
		WebCamDevice[] devices = WebCamTexture.devices;
		string backCamName="";
		for( int i = 0 ; i < devices.Length ; i++ ) {
			Debug.Log("Device:"+devices[i].name+ "IS FRONT FACING:"+devices[i].isFrontFacing);
			
			if (!devices[i].isFrontFacing) {
				backCamName = devices[i].name;
			}
		}
		 
		CameraTexture = new WebCamTexture(backCamName, 320, 180, 30);
		CameraTexture.Play();
		BackgroundTexture.texture = CameraTexture;
		
	}
}
