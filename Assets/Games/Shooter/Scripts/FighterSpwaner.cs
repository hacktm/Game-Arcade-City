using UnityEngine;
using System.Collections.Generic;

public class FighterSpwaner : MonoBehaviour
{
		public GameObject FighterPrefab;

		public int NrOfFighters = 5;
		
		public static List<Fighter> fighters = new List<Fighter>();
		
		public static List<PlayerLaser> playerLasers = new List<PlayerLaser>();

		// Use this for initialization
		void Start ()
		{
			init();
		}
	
		// Update is called once per frame
		void Update ()
		{
			checkForCollisions();
		}

		private void checkForCollisions(){
			List<PlayerLaser> lasers = new List<PlayerLaser>(playerLasers);

			List<Fighter> fighters1 = new List<Fighter>(fighters);
			
			List<PlayerLaser> lasersToRemove = new List<PlayerLaser>();

			List<Fighter> fightersToRemove = new List<Fighter>();


			foreach(PlayerLaser laser in lasers){
				foreach(Fighter fighter in fighters1){
					float dist = (laser.gameObject.transform.position - fighter.gameObject.transform.position).magnitude;

					if (dist < 3.0f){
						//fightersToRemove.Add(fighter);
						//lasersToRemove.Remove(laser);
					}
				}
			}

			foreach(PlayerLaser l in lasersToRemove){
				//playerLasers.Remove(l);
				//Destroy(l.gameObject);
			}

			foreach(Fighter f in fightersToRemove){
				//fighters.Remove(f);
				//Destroy(f.gameObject);
			}

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

