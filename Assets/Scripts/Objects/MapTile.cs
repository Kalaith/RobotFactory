using System.Collections;
using System.Collections.Generic;

public enum TileType {
	GRASS = 0,
	WALL
}

public class MapTile {
	pointf pos;
	TileType type;

	public MapTile(float x, float y, TileType t = TileType.GRASS) {
		pos = new pointf (x, y);
		type = t;
	}

	public void setPosition(float x, float y) {
		pos.X = x;
		pos.Y = y;
	}

	public pointf getPosition() {
		return pos;
	}

	public TileType getTileType() {
		return type;
	}
}

