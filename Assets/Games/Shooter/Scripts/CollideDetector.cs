using UnityEngine;
using System.Collections;

public class CollideDetector : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

	public void OnTriggerEnter(Collider  coll){
		Debug.Log("TRIGGER WITH: "+coll.gameObject);
	}
}

