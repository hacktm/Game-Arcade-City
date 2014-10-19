using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour
{

	public Vector3 Target;

	public float Speed = 20;

	void Start ()
	{

	}

	void Update ()
	{
		Vector3 direction = (Target - transform.localPosition);

		if (direction.magnitude < 1){
			Debug.Log("HIT HIT");
			Destroy(this.gameObject);
		}

		transform.localPosition += direction.normalized * Speed * Time.deltaTime;

		transform.localRotation = Quaternion.LookRotation(direction);
	}
}

