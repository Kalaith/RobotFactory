using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : MonoBehaviour {

	PlayerController pc;
    NPCController npcs;
    UIController ui;
    // Use this for initialization
    void Start () {
		pc = (PlayerController)FindObjectOfType(typeof(PlayerController));
        npcs = (NPCController)FindObjectOfType(typeof(NPCController));
        ui = (UIController)FindObjectOfType(typeof(UIController));
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKey("w") || Input.GetKey("up")) {
			pc.Player.setAcceleration(new pointf(0, pc.Player.Speed));
			ui.Canvas.SetActive(false);
		}
		if (Input.GetKey("s") || Input.GetKey("down")) {
			pc.Player.setAcceleration(new pointf(0, -pc.Player.Speed));
			ui.Canvas.SetActive(false);
		}
		if (Input.GetKey("d") || Input.GetKey("right")) {
			pc.Player.setAcceleration(new pointf(pc.Player.Speed, 0));
			ui.Canvas.SetActive(false);
		}
		if (Input.GetKey("a") || Input.GetKey("left")) {
			pc.Player.setAcceleration(new pointf(-pc.Player.Speed, 0));
			ui.Canvas.SetActive(false);
		}


        if(Input.GetKeyDown("i")) {

			if (ui.Canvas.activeInHierarchy) {
				ui.Canvas.SetActive (false);

			} else {
				pointf pos = pc.Player.getPosition ();
				bool matches = false;
				foreach (Character npc in npcs.Character) {
					//Debug.Log("Test Player: "+pos.X+"|"+pos.Y);
					// Test if th player is touching any NPC's
					if (pos == npc.getPosition ()) {
						if (npc.Interactable == true) {
							ui.Canvas.SetActive (true);



							ui.setText (npc.Talk + "\n" + TextGen.ramble());
							matches = true;
						}
					}
				}
				if (matches == false) {
					ui.Canvas.SetActive (false);
				}
			}
        }
	}
}
