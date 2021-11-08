using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LaserScript : MonoBehaviour {


	public float rotationSpeed = 0.0f;

	void Start () {

	}

	void Update () {
		
	}

	void FixedUpdate () {
		transform.RotateAround(transform.position, Vector3.forward, rotationSpeed * Time. fixedDeltaTime);
	}
}
