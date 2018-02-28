using System.Collections;
using System.Collections.Generic;

public class Character
{

    pointf pos;
    pointf acceleration;
	float speed;
	bool interactable;
    string talk;
	Inventory inventory;

	public Inventory Inventory { get { return inventory; } set { inventory = value; } }

    public bool Interactable { get { return interactable; } set { interactable = value; } }
	public string Talk { get { return talk; } set { talk = value; } }
	public float Speed { get { return speed; } set { speed = value; } }

    public Character(float x, float y, int s = 2, bool inter = false)
    {
        setPosition(x, y);
        setAcceleration(new pointf(0, 0));
		speed = s;
		inventory = new Inventory ();
    }

    public pointf getPosition()
    {
        return pos;
    }

    public void setPosition(float x, float y)
    {
        pos = new pointf(x, y);
    }

    public pointf getAcceleration()
    {
        return acceleration;
    }

    public void setAcceleration(pointf a)
    {
        acceleration = a;
    }

	public void moveCharacter(float delta)
    {
		pos = pos + (acceleration*delta);
    }

}
