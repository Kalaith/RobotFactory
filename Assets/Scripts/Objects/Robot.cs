using System.Collections;
using System.Collections.Generic;

public class Robot : Character
{
    string name;

    public Robot(float x, float y, string name) : base(x, y) {
        this.name = name;
    }

}
