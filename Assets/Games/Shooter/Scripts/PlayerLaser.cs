using UnityEngine;
using System.Collections;

public class PlayerLaser : MonoBehaviour
{

	public Vector3 Direction;
	
	public float Speed = 20;

	public float StartTime;

	void Start ()
	{
		gameObject.tag = "PlayerLaser";
		FighterSpwaner.playerLasers.Add(this);

		StartTime = Time.time;
	}
	
	void Update ()
	{

		transform.localPosition += transform.forward * Speed * Time.deltaTime;
		
	}

}

