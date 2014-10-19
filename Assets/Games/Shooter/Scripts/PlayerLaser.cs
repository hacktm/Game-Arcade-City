using UnityEngine;
using System.Collections;

public class PlayerLaser : MonoBehaviour
{

	public Vector3 Direction;
	
	public float Speed = 20;
	
	void Start ()
	{
		gameObject.tag = "PlayerLaser";
	}
	
	void Update ()
	{

		transform.localPosition += transform.forward * Speed * Time.deltaTime;
		
	}
}

