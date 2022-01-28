using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTest : MonoBehaviour
{
    Vector2 origin = new Vector2(0, 0);

    MyVector2D firstVector = new MyVector2D(1, 3);
    MyVector2D secondVector = new MyVector2D(2, -1);

    MyVector2D suma;
    MyVector2D resta;
    MyVector2D multiply;

    float magnitud;
    MyVector2D normalizar;

    // Start is called before the first frame update
    void Start()
    {

        suma = firstVector.add(secondVector);
        resta = firstVector.substract(secondVector);
        multiply = firstVector.multiplyScalar(2);
        magnitud = firstVector.magnitud();
        normalizar = firstVector.normalizar();

        Debug.Log("magnitud = " + magnitud);
        Debug.Log("normalizado = " + normalizar);
    }

    // Update is called once per frame
    void Update()
    {
        firstVector.Draw(origin, Color.white);
        secondVector.Draw(origin, Color.white);

        suma.Draw(origin, Color.grey); 
        suma.Draw(new Vector2 (firstVector.x, firstVector.y), Color.black);
       
        resta.Draw(origin, Color.blue);
        resta.Draw(new Vector2(secondVector.x, secondVector.y), Color.cyan);

        multiply.Draw(origin, Color.green);

    }
}
