using UnityEngine;
using System.Collections;

public class BorderHitSc : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x > 23)
		{
			Vector3 pos = transform.position;
			
			pos.x = -23;
			
			transform.position = pos;
		}
		else if(transform.position.x < -23)
		{
			Vector3 pos = transform.position;
			
			pos.x = 23;
			
			transform.position = pos;
		}
		else if(transform.position.z < -10)
		{
			Vector3 pos = transform.position;
			
			pos.z = 10;
			
			transform.position = pos;
		}
		else if(transform.position.z > 10)
		{
			Vector3 pos = transform.position;
			
			pos.z = -10;
			
			transform.position = pos;
		}
		
	}
}
