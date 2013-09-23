using UnityEngine;
using System.Collections;

public class GameCtrlSc : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		
		for(int i = 0; i < 3; i++)
		{
			Vector3 astPos = new Vector3(Random.Range(-23,23),0,Random.Range(-10,10));
			//player.transform.position.y;
			GameObject astro = Instantiate(Resources.Load("Asteroids"),astPos,Quaternion.identity) as GameObject;
			astro.GetComponent<AsterSc>().isBig = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
