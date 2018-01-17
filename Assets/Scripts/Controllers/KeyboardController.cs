using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour {

	PlayerController pc;
	// Use this for initialization
	void Start () {
		pc = (PlayerController)FindObjectOfType(typeof(PlayerController));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")) {
			pc.Player.movePlayer(0, 0.1f);
		}
		if (Input.GetKey("s")) {
			pc.Player.movePlayer (0, -0.1f);
		}
		if (Input.GetKey("d")) {
			pc.Player.movePlayer (0.1f, 0);
		}
		if (Input.GetKey("a")) {
			pc.Player.movePlayer (-0.1f, 0);
		}
	}
}
