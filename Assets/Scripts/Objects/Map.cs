using System.Collections;
using System.Collections.Generic;

public class Map {

	MapTile[,] map;

	public void initEmptyMap(int mapX, int mapY) {
		map = new MapTile[mapX, mapY];

		for (int i = 0; i >= mapX; i++) {
			for (int j = 0; j >= mapY; j++) {
				map[i,j] = new MapTile(i, j);
			}
		}
	}

	public void initTestMap(int mapX, int mapY) {
		map = new MapTile[mapX, mapY];

		for (int i = 0; i < mapX; i++) {
			for (int j = 0; j < mapY; j++) {
				if (i == 0 || j == 0 || i + 1 == mapX || j + 1 == mapY) {
					map [i, j] = new MapTile (i, j, TileType.WALL);
				} else {
					map [i, j] = new MapTile (i, j);
				}
			}
		}			
	}

	public MapTile getTile(float x, float y) {
		// should add a check to make sure a tile exists at this location, else reurn null
		return map [(int)x, (int)y];
	}

	MapTile[] getTileNeighbours (pointf pos, bool diag = false) {
		MapTile[] neighbours;

		if (diag) {
			neighbours = new MapTile[8];
		} else { 
			neighbours = new MapTile[4];
		}

		if (diag) {
			neighbours[4] = getTile (pos.X+1f, pos.Y-1f); // TOP-LEFT
			neighbours[5] = getTile (pos.X+1f, pos.Y+1f); // TOP-RIGHT
			neighbours[6] = getTile (pos.X-1f, pos.Y-1f); // DOWN-LEFT
			neighbours[7] = getTile (pos.X+1f, pos.Y-1f); // DOWN-RIGHT
		}

		neighbours[0] = getTile (pos.X+1f, pos.Y); // UP
		neighbours[1] = getTile (pos.X-1f, pos.Y); // DOWN
		neighbours[2] = getTile (pos.X, pos.Y+1f); // RIGHT
		neighbours[3] = getTile (pos.X, pos.Y-1f); // LEFT

		return neighbours;
	}

}
