using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

	private Rigidbody2D rigidbody;

	public Transform axis;

	public float Speed = 1;
	public float MaxSpeed = 30;
	public float RotationSpeed = 1;

	// Use this for initialization
	void Start () {

		rigidbody = GetComponent<Rigidbody2D>();


	}

	// Update is called once per frame
	void Update () {
			

	}

	void FixedUpdate(){

		if (this.rigidbody.velocity.magnitude < MaxSpeed)
			this.rigidbody.AddForceAtPosition (Input.GetAxis("Vertical") * MaxSpeed * this.transform.up, axis.transform.position );
				
		if (this.rigidbody.velocity.magnitude > 0.1) {
			
			this.rigidbody.AddTorque(Input.GetAxis("Horizontal") * RotationSpeed * -1);

			                         
		 }

	}
}
