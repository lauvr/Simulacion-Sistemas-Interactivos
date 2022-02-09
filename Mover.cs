using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //[SerializeField]
    Vector3 displacement;
    [SerializeField]
    Vector3 velocity;

    public void Update()
    {
        Move();
    }

    public void Move()
    {
        displacement = velocity * Time.deltaTime;
        transform.position = transform.position + displacement;
    }
}
