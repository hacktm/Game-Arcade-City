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

			if (Random.value < 0.3f){
				Score.life--;
				Debug.Log("Life: "+Score.life);
			}

			Destroy(this.gameObject);
		}

		transform.localPosition += direction.normalized * Speed * Time.deltaTime;

		transform.localRotation = Quaternion.LookRotation(direction);
	}
}

