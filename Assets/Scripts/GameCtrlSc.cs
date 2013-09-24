using UnityEngine;
using System.Collections;

public class GameCtrlSc : MonoBehaviour {
	
	private int score = 0;
	private float alienTime = 8;
	// Use this for initialization
	void Start () {
		
		//GameObject player = GameObject.FindGameObjectWithTag("Player");
		
		SpawnAster(3);
		ScoreChange(0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		alienTime -= Time.deltaTime;
		
		if(alienTime < 0)
		{
			Vector3 astPos = new Vector3(-23,0,Random.Range(-7,9));
			alienTime = Random.Range(6,12);
			Instantiate(Resources.Load("AlienShip"),astPos,Quaternion.identity);
		}
		
	}
	
	public void ScoreChange(int change)
	{
		score += change;
		
		
		GameObject scoreHud = GameObject.Find("ScoreHud");
		scoreHud.GetComponent<GUIText>().text = "" + score;
	}
	
	public void SpawnAster(int astrAmount)
	{
		for(int i = 0; i < astrAmount; i++)
		{
			Vector3 astPos = new Vector3(Random.Range(-23,23),0,Random.Range(-10,10));
			//player.transform.position.y;
			GameObject astro = Instantiate(Resources.Load("Asteroids"),astPos,Quaternion.identity) as GameObject;
			astro.GetComponent<AsterSc>().isBig = true;
		}
	}
}
