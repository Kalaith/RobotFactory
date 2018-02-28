using System.Collections;
using System.Collections.Generic;

public class pointf {
	private float x;

	public float X {
		get {
			return x;
		}
		set {
			x = value;
		}
	}

	private float y;

	public float Y {
		get {
			return y;
		}
		set {
			y = value;
		}
	}

	public pointf(float x, float y){
		X = x;
		Y = y;
	}

	public static pointf operator *(pointf p1, float p2) {
		return new pointf (p1.X * p2, p1.Y * p2);
	}

	public static pointf operator +(pointf p1, pointf p2) {
		return new pointf (p1.X + p2.X, p1.Y + p2.Y);
	}

    public static bool operator ==(pointf p1, pointf p2)
    {
        if((int)p1.X == (int)p2.X && (int)p1.Y == (int)p2.Y)
        {
            return true;
        }
        return false;
    }

    public static bool operator !=(pointf p1, pointf p2)
    {
        if ((int)p1.X == (int)p2.X && (int)p1.Y == (int)p2.Y)
        {
            return false;
        }
        return true;
    }

    public override string ToString() {
		return x + ":" + y;
	}
}
