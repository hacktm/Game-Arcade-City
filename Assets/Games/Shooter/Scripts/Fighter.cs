using UnityEngine;
using System.Collections;

public class Fighter : MonoBehaviour {

	private Vector3 Destination;

	private Vector3 Direction = new Vector3(0,0,-1);

	private float Speed = 3;

	private float SpawnDistance = 50;

	Vector3 target = new Vector3(0,3,0);

	public FighterSpwaner spwaner;

	public GameObject Laser;

	private float LastFired;

	private float FireRate = 3;

	// Use this for initialization
	void Start () {
		init();
		LastFired = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		float delta = Time.time - LastFired;

		if (delta > FireRate){
			LastFired = Time.time;
			Fire ();
		}

		transform.localPosition += Direction * Time.deltaTime * Speed;

		Vector3 NewDirection = (target - transform.position).normalized;
		
		transform.localRotation = Quaternion.LookRotation(NewDirection);

		if (transform.position.magnitude > SpawnDistance * 2){
			init();
		}
	}


	private void init()
	{
		FireRate += Random.value * 2; 

		target.x = Random.value * 5;

		target.y = 3 + Random.value * 5;

		Speed = 5 + Random.value*5;

		Vector3 startPosition = Random.onUnitSphere * SpawnDistance;

		transform.position = startPosition;

		Direction = (target - transform.position).normalized;

		transform.localRotation.SetLookRotation(Direction.normalized);

	}

	private void Fire(){
		GameObject go = (GameObject) Instantiate(Laser, transform.position, transform.rotation);

		Laser laser = go.GetComponent<Laser>();

		laser.Target = new Vector3(0,3,0);

		Destroy(go, 5);
	}


}
