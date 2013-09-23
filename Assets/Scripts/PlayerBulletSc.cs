using UnityEngine;
using System.Collections;

public class PlayerBulletSc : MonoBehaviour {
	
	public float lifeTime;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
		rigidbody.velocity = Vector3.zero;
		
		rigidbody.AddRelativeForce(new Vector3(0,0,22000 * Time.deltaTime));
		
	}
}
