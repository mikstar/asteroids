using UnityEngine;
using System.Collections;

public class AlienSc : MonoBehaviour {

	private float shootTime = 3;
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = Vector3.zero;
		rigidbody.AddForce(new Vector3(100,0,0 * Time.deltaTime));
		
		
		shootTime -= Time.deltaTime;
		
		if(shootTime < 0)
		{
			shootTime = 3;
			
			Instantiate(Resources.Load("EnemyBullet"),transform.position,transform.rotation);
		}
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.tag == Tags.player)
		{
			Destroy(col.gameObject);
		}
		else if(col.tag == Tags.bullet)
		{
			GameObject control = GameObject.Find("ControllObject");
			control.GetComponent<GameCtrlSc>().ScoreChange(200);
			
			Destroy(col.gameObject);
			Destroy(gameObject);
			
		}
		
		
	}
}
