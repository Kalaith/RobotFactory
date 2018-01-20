using System.Collections;
using System.Collections.Generic;

public class Player  : Character {

	public Player(float x, float y) : base(x, y) {

	}

    public void movePlayer()
    {
        moveCharacter();
    }

}
