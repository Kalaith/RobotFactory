using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Player player;
	GameObject pgo;

	public Sprite p_sprite;

	public Player Player {
		get {
			return player;
		}

		set {
			player = value;
		}
	}

	// Use this for initialization
	void Start () {
		player = new Player (5, 5);

		pgo = new GameObject ();

		pgo.AddComponent<SpriteRenderer> ();
		pgo.GetComponent<SpriteRenderer> ().sprite = p_sprite;
		pgo.GetComponent<SpriteRenderer> ().sortingOrder = 10;

        pgo.name = "Player";
        pgo.tag = "Player";
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null) {
			pointf pos = Player.getPosition ();
			pgo.transform.position = new Vector3 (pos.X, pos.Y, 0);
			Camera.main.transform.position = new Vector3 (pos.X, pos.Y, Camera.main.transform.position.z);
		}
	}


    public void movePlayer()
    {
        player.movePlayer();
    }
}
