using System.Collections;
using System.Collections.Generic;

public class Character
{

    pointf pos;
    pointf speed;
    bool interactable;
    string talk;

    public bool Interactable
    {
        get
        {
            return interactable;
        }

        set
        {
            interactable = value;
        }
    }

    public string Talk { get { return talk; } set { talk = value; } }

    public Character(float x, float y, bool inter = false)
    {
        setPosition(x, y);
        setSpeed(new pointf(0, 0));
    }

    public pointf getPosition()
    {
        return pos;
    }

    public void setPosition(float x, float y)
    {
        pos = new pointf(x, y);
    }

    public pointf getSpeed()
    {
        return speed;
    }

    public void setSpeed(pointf s)
    {
        speed = s;
    }

    public void moveCharacter()
    {
        pos = pos + speed;
    }

}
