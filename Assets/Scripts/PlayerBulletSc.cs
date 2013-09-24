using UnityEngine;
using System.Collections;

public class PlayerBulletSc : MonoBehaviour {
	
	public float lifeTime;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
		rigidbody.velocity = Vector3.zero;
		
		rigidbody.AddRelativeForce(new Vector3(0,0,30000 * Time.deltaTime));
		
	}
}
