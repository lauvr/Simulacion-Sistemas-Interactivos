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

    public MyVector2D multiplyScalar(float scalar)
    {
        MyVector2D result3 = new MyVector2D(x * scalar, y * scalar); 
        return result3;
    }

    public float magnitud()
    {
        float result4 = Mathf.Sqrt((x * x) + (y*y));
        return result4;
    }

    public MyVector2D normalizar()
    {

        MyVector2D result5 = new MyVector2D(x/ Mathf.Sqrt((x * x) + (y * y)), y/ Mathf.Sqrt((x * x) + (y * y)));
        return result5;
    }


    public void Draw(Vector2 origin, Color color)
    {
        if (origin == null)
        {
            Debug.DrawLine(new Vector2(0, 0), new Vector2(x, y), color);
        }
        Debug.DrawLine(new Vector2(origin.x, origin.y), new Vector2(x+origin.x, y+origin.y), color);
    }

}
