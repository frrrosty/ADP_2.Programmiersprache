using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody rb = GetComponent<Rigidbody>();

        // Add a force to the Rigidbody.
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(Vector3.left * 5);
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(Vector3.right * 5);
        if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(Vector3.up * 10);
        if (Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(Vector3.down * 5);
    }
}