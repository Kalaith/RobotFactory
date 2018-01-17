using System.Collections;
using System.Collections.Generic;

public class Player  {

	pointf pos;

	public Player(float x, float y) {
		setPosition (x, y);
	}

	public pointf getPosition() {
		return pos;
	}

	public void setPosition(float x, float y) {
		pos = new pointf (x, y);
	}

	public void movePlayer(float x, float y) {
		pos = pos + new pointf (x, y);
	}

}
