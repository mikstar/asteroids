using UnityEngine;
using System.Collections;

public class PlayerSc : MonoBehaviour {

	
	private bool firepress = false;
	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 50;
	}
	
	// Update is called once per frame
	void Update () {
		
		rigidbody.velocity = Vector3.zero;
		
		float directionY = Input.GetAxis("Vertical") * 3;
		rigidbody.AddRelativeForce(new Vector3(0,0,directionY * 6000 * Time.deltaTime));
		
		float directionX = Input.GetAxis("Horizontal") * 3;
		transform.Rotate(0,directionX * 40 * Time.deltaTime,0);
		
		if(Input.GetAxis("Fire1") == 1 )
		{
			if(firepress == false)
			{
				firepress = true;
				Instantiate(Resources.Load("PlayerBullet"),transform.position,transform.rotation);
			}
		}
		else{
			firepress = false;	
		}
		
		
	}
}
