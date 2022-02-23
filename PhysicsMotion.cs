using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyMath;

public class PhysicsMotion : MonoBehaviour {

	// friccion = -1 * u * v(normalizado)

	[SerializeField]
	Vector3 acceleration;

	[SerializeField] 
	private float mass;

	[SerializeField] 
	private float gravity;

	private float weight;

	[SerializeField]
	[Range(0,1)] float damping = 0.9f;

	Vector3 displacement;
	Vector3 velocity;
	[SerializeField]float xBorder, yBorder;

	[SerializeField]
	[Range(0,1)] float u;

	Vector3 friction;


	public void Start(){

		weight = mass * gravity;
	}

	public void Update()
	{
		friction = -1* u * velocity.normalized;
		ApplyForce (friction);
		ApplyForce (new Vector3(0, weight, 0));
		ApplyForce (new Vector3 (0, gravity, 0));
		Move();
		CheckCollision ();
		acceleration = Vector3.zero;
	}

	public void Move()
	{
		velocity += acceleration * Time.deltaTime;

		displacement = velocity * Time.deltaTime;

		transform.position = transform.position + displacement;

		velocity.Draw (transform.position, Color.green);
		transform.position.Draw (Color.red);
	}

	public void CheckCollision(){

		if (transform.position.x >= xBorder || transform.position.x <= -xBorder) {
			velocity.x = velocity.x * -1 * damping;
		}
		if (transform.position.y >= yBorder || transform.position.y <= -yBorder) {
			velocity.y = velocity.y * -1 * damping;
		}


		if (transform.position.x > xBorder ) {
			transform.position = new Vector3(xBorder, transform.position.y) ;
		}
		if (transform.position.x < -xBorder) {
			transform.position = new Vector3(-xBorder, transform.position.y);
		}
		if (transform.position.y > yBorder) {
			transform.position = new Vector3(transform.position.x, yBorder);
		}
		if (transform.position.y < -yBorder) {
			transform.position = new Vector3(transform.position.x, -yBorder);;
		}
	}


	private void ApplyForce(Vector3 force){
	
		acceleration += force / mass;

	}

}
