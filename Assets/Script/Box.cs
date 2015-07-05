using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {
	public Vector3 tilt;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//tilt.y = Input.acceleration.y;
		//tilt.x = Input.acceleration.x;
		tilt.z = Input.acceleration.y;
		transform.Rotate(tilt);
	}


}
