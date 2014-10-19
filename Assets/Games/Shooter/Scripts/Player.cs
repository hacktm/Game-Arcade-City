using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public GameObject laser;

	bool registeredSensor = false;
	// Use this for initialization
	void Start ()
	{
		if (!registeredSensor){
			registeredSensor = true;
			MagnetSensor.OnCardboardTrigger += OnCardboardTrigger;
		}
	}

	// Update is called once per frame
	void Update ()
	{

	}


	void OnCardboardTrigger(){
		GameObject go = (GameObject) Instantiate(laser, transform.position+transform.forward, transform.rotation);

		Destroy(go, 5);
	}
}

