using UnityEngine;
using System.Collections;

public class EnemyBulletSc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.Rotate(0,Random.Range(-180,180),0);
		
		Destroy(gameObject, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
		rigidbody.velocity = Vector3.zero;
		
		rigidbody.AddRelativeForce(new Vector3(0,0,25000 * Time.deltaTime));
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.tag == Tags.player)
		{
			Destroy(col.gameObject);
			Destroy(gameObject);
		}
	}
}
