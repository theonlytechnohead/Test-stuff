using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform Player;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		var pos = transform.position;
		var targetPos = Player.position;
		targetPos.y += 10;
		pos = Vector3.Lerp(pos, targetPos, 3f * Time.deltaTime);
		transform.position = pos;

		var rot = transform.rotation;
		var targetRot = Player.rotation;
		var targetEuler = targetRot.eulerAngles;
		targetEuler.x = 90;
		targetRot = Quaternion.Euler(targetEuler);
		rot = Quaternion.Slerp(rot, targetRot, 5f * Time.deltaTime);
		transform.rotation = rot;
	}
}
