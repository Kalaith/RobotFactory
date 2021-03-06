﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    PlayerController player;
    MapController map;
    NPCController npcs;

	// Use this for initialization
	void Start () {
        player = (PlayerController)FindObjectOfType(typeof(PlayerController));
        map = (MapController)FindObjectOfType(typeof(MapController));
        npcs = (NPCController)FindObjectOfType(typeof(NPCController));

    }
	
	// Update is called once per frame
	void Update () {

		MapTile m = map.Map.getTile(player.Player.getPosition() + (player.Player.getAcceleration()*Time.deltaTime));
        if(m.Collidable==false)
        {
			player.movePlayer(Time.deltaTime);
            player.Player.setAcceleration(new pointf(0, 0));
        }

	}
}
