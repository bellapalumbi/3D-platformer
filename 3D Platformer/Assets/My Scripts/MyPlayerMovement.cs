using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerMovement : MonoBehaviour {

	public Rigidbody my_rb;
	public RaycastHit hit;

	void Update() {
		
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 8.0f;
		var y = Input.GetAxis("Vertical") * Time.deltaTime * 8.0f;
		


		if (Input.GetKeyDown(KeyCode.Space)) {
			Jump();
		}
		

		transform.Translate(0,0,y);
		transform.Translate(x,0,0);
		
	}

	void Jump() {
		hit = Physics.Raycast(new Vector3(transform.position.x, transform.position.y-0.2f, transform.position.z), -Vector3.up,0.1f);
		if() {
			print("Jumped");
			my_rb.AddForce(transform.up * 300);
		}
	}

}
