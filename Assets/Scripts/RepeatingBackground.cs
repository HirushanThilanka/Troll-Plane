using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour {

	private PolygonCollider2D groundcollider;
	private float groundhorizonlenght;

	// Use this for initialization
	void Start () {


		groundhorizonlenght = 18.65f;
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if (transform.position.x < -groundhorizonlenght) {
		
		
			RepositionBackground ();
		}
	}

	private void RepositionBackground()
	{

		Vector2 groundoffset = new Vector2 (groundhorizonlenght * 2f , 0 );
		transform.position = (Vector2)transform.position + groundoffset;
	}
}
