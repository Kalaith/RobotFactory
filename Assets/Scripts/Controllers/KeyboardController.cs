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
		if (Input.GetKey("w")) {
			pc.Player.setSpeed(new pointf(0, 0.1f));
		}
		if (Input.GetKey("s")) {
			pc.Player.setSpeed(new pointf(0, -0.1f));
		}
		if (Input.GetKey("d")) {
			pc.Player.setSpeed(new pointf(0.1f, 0));
		}
		if (Input.GetKey("a")) {
			pc.Player.setSpeed(new pointf(-0.1f, 0));
		}

        if(Input.GetKey("i")) {
            pointf pos = pc.Player.getPosition();
            bool matches = false;
            foreach (Character npc in npcs.Character)
            {
                //Debug.Log("Test Player: "+pos.X+"|"+pos.Y);
                // Test if th player is touching any NPC's
                if (pos == npc.getPosition())
                {
                    if (npc.Interactable == true)
                    {
                        ui.Canvas.SetActive(true);

                        // Talk trash
                        string ramble = "";
                                                
                        int lines = Random.Range(1, 5);
                        for (int i = 0; i < lines; i++)
                        {
                            int words = Random.Range(1, 20);
                            for (int j = 0; j < words; j++)
                            {
                                int letters = Random.Range(1, 10);
                                for (int k = 0; k < letters; k++)
                                {
                                    char numToChar = (char)Random.Range(65, 90);
                                    ramble += numToChar.ToString();
                                }
                                if (j == words) {
                                    ramble += ".";
                                } else
                                {
                                    ramble += " ";
                                }
                            }
                            ramble += "\n";
                            
                        }
                        ui.setText(npc.Talk+"\n"+ramble);
                        matches = true;
                    }
                }
            }
            if(matches==false)
            {
                ui.Canvas.SetActive(false);
            }
        }
	}
}
