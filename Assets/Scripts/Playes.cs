using UnityEngine;
using System.Collections;

public class Playes : MonoBehaviour {
	Vector2 jumpForce = new Vector2(0,300);
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			GetComponent<Rigidbody2D> ().AddForce (jumpForce);
		}
		Vector2 screenposition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenposition.y > Screen.height || screenposition.y < 0) {
			Die ();
		}


	}
	void Die(){
		Application.LoadLevel (Application.loadedLevel);
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		Die ();
	}

	}
		
	


