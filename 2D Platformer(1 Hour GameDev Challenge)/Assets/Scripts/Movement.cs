using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed = 5f;
	public float jump_Force = 4f;
	public float radius = 6f;

	Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.D)) {
			rb.AddForce (Vector2.right * speed * Time.deltaTime, ForceMode2D.Force);
		}

		if (Input.GetKey (KeyCode.A)) {
			rb.AddForce (Vector2.left * speed * Time.deltaTime, ForceMode2D.Force);
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			Collider2D[] colliders = Physics2D.OverlapCircleAll (transform.position, radius);
			foreach (Collider2D collider in colliders) {
				if (collider.CompareTag ("Ground") || collider.CompareTag ("Wall")) {
					rb.velocity = new Vector2 (0f, jump_Force);
					if (Input.GetKey (KeyCode.D)) {
						rb.AddForceAtPosition (Vector2.right * speed * Time.deltaTime, transform.position, ForceMode2D.Force);
					}

					if (Input.GetKey (KeyCode.A)) {
						rb.AddForceAtPosition (Vector2.left * speed * Time.deltaTime, transform.position, ForceMode2D.Force);
					}
				}
			}
		}
	}
}