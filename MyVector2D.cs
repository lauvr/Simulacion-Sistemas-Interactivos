using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVector2D 
{
    public float x;
    public float y;

    public MyVector2D(float xComponent, float yComponent)
    {
        x = xComponent;
        y = yComponent;
    }

    public void Draw(Color color)
    {
        Debug.DrawLine(new Vector2(0, 0), new Vector2(x, y), color);
    }

    public void DrawWithOrigin(Vector2 origin)
    {
        Debug.DrawLine(origin, new Vector2(x, y));
    }

    public override string ToString()
    {
        return ("(" + x + ", " + y + ")");
    }

    public MyVector2D add(MyVector2D vector)
    {
        MyVector2D result = new MyVector2D(x + vector.x, y + vector.y);
        return result;
    }

    public MyVector2D substract(MyVector2D vector)
    {
        MyVector2D result2 = new MyVector2D(x - vector.x, y - vector.y);
        return result2;
    }

}
