using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public float speed;
	public Rigidbody body;
	public Vector3 tilt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(Input.acceleration.x/2, Input.acceleration.y/2,0);
		 
		tilt.z = Input.acceleration.y;
		tilt.x = Input.acceleration.x;
		body.AddForce(tilt*speed*Time.deltaTime);

	}
}
