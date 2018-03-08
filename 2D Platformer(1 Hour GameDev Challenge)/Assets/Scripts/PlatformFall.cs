using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{
	public float delay = 4f;

	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.collider.CompareTag ("Player")) {
			Invoke ("Fall", delay);
		}
	}

	void Fall ()
	{
		rb.isKinematic = false;
	}
}