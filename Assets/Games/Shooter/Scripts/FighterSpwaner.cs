using UnityEngine;
using System.Collections.Generic;

public class FighterSpwaner : MonoBehaviour
{
		public GameObject FighterPrefab;

		public int NrOfFighters = 5;
		
		private List<Fighter> fighters = new List<Fighter>();

		// Use this for initialization
		void Start ()
		{
			init();
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}

		private GameObject SpwanFighter(){
			
			GameObject go = (GameObject) Instantiate(FighterPrefab, new Vector3(0,30,0), Quaternion.identity);
			
			Fighter fighter = go.GetComponent<Fighter>();

			fighter.spwaner = this;

			fighters.Add(fighter);

			return go;
		}

		private void init(){
			for(int i=0;i<NrOfFighters;i++){
				SpwanFighter();
			}
		}

		
}

