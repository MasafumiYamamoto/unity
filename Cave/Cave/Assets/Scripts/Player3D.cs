using UnityEngine;
using System.Collections;

public class Player3D : MonoBehaviour {
	
	Rigidbody rigidbody3D;
	Vector3 velocity;
	
	void Start () {
		rigidbody3D = GetComponent<Rigidbody> ();
	}
	
	void Update () {
		velocity = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")).normalized * 10;
	}
	
	void FixedUpdate() {
		rigidbody3D.MovePosition (rigidbody3D.position + velocity * Time.fixedDeltaTime);
	}
}