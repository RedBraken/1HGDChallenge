using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
	public GameObject gameOverPanel;
	public float delay = 1f;

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.collider.CompareTag ("Player")) {
			Invoke ("Appear", delay);
		}
	}

	void Appear ()
	{
		gameOverPanel.gameObject.SetActive (true);
	}
}