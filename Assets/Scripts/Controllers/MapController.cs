using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour {

	int mapSizeX = 15;
	int mapSizeY = 8;
	public Sprite grass;
	public Sprite wall;
	private Map map;

	private GameObject[,] goMap;

    public Map Map
    {
        get
        {
            return map;
        }

        set
        {
            map = value;
        }
    }

    // Use this for initialization
    void Start () {
		map = new Map ();
		map.initTestMap (mapSizeX, mapSizeY);
		goMap = new GameObject[mapSizeX, mapSizeY];
		buildMap ();
	}

	void buildMap() {
		for (int i = 0; i < mapSizeX; i++) {
			for (int j = 0; j < mapSizeY; j++) {
				GameObject pgo = new GameObject ();//goMap [i, j];

				pgo.AddComponent<SpriteRenderer> ();
				TileType type = map.getTile(i, j).getTileType ();

				if (type == TileType.WALL) {
					pgo.GetComponent<SpriteRenderer> ().sprite = wall;
				}
				if (type == TileType.GRASS) {
					pgo.GetComponent<SpriteRenderer> ().sprite = grass;
				}
				pgo.GetComponent<SpriteRenderer> ().sortingOrder = 9;

				pgo.transform.position = new Vector3 (i, j, 0);

				pgo.transform.parent = this.transform;
				pgo.name = "Tile "+i+":"+j;
				goMap [i, j] = pgo;
				//Debug.Log ("GO " + i +":"+ j + " Created");
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
