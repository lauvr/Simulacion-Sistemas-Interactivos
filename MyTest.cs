using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTest : MonoBehaviour
{
    MyVector2D firstVector = new MyVector2D(1, 3);
    MyVector2D secondVector = new MyVector2D(2, -1);
    MyVector2D suma;
    MyVector2D resta;

    // Start is called before the first frame update
    void Start()
    {

        suma = firstVector.add(secondVector);
        resta = firstVector.substract(secondVector);

        Debug.Log(suma);
        Debug.Log(resta);

    }

    // Update is called once per frame
    void Update()
    {
        firstVector.Draw(Color.white);
        secondVector.Draw(Color.white);

        suma.Draw(Color.red);
        resta.Draw(Color.red);
    }
}
