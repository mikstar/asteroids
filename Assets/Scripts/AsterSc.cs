using UnityEngine;
using System.Collections;

public class AsterSc : MonoBehaviour {
	
	public bool isBig = false;
	// Use this for initialization
	void Start () {
		transform.Rotate(0,Random.Range(-180,180),0);
	}
	
	// Update is called once per frame
	void Update () {
		
		rigidbody.velocity = Vector3.zero;
		
		rigidbody.AddRelativeForce(new Vector3(0,0,4000 * Time.deltaTime));
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.tag == Tags.player)
		{
			Destroy(col.gameObject);
			GameObject control = GameObject.Find("ControllObject");
			control.GetComponent<GameCtrlSc>().PlayerSpawn();
		}
		else if(col.tag == Tags.bullet)
		{
			if(isBig)
			{
				for(int i = 0; i < 5 ; i++)
				{
					Instantiate(Resources.Load("SmallAst"),transform.position,Quaternion.identity);
				}
			}
			GameObject control = GameObject.Find("ControllObject");
			control.GetComponent<GameCtrlSc>().ScoreChange(50);
			
			Destroy(col.gameObject);
			Destroy(gameObject);
			
		}
	}
}
