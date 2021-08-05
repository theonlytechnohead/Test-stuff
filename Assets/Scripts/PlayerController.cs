using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {

	Vector2 move;
	[Range(1, 10)]
	public float moveSpeed = 5f;
	[Range(10, 100)]
	public float rotationSpeed = 10f;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

	}

	void FixedUpdate() {
		transform.position = Vector3.Lerp(transform.position, transform.position + transform.forward * move.y * moveSpeed, Time.deltaTime);
		var rot = transform.rotation.eulerAngles;
		rot.y = Mathf.LerpAngle(rot.y, rot.y + move.x * rotationSpeed * move.y, Time.deltaTime);
		transform.rotation = Quaternion.Euler(rot);
	}

	void OnMove(InputValue value) {
		move = value.Get<Vector2>();
	}
}
