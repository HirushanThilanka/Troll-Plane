using UnityEngine;
using System.Collections;

public class plane : MonoBehaviour {

	public float upforce = 200f;
	private bool isDead = false;
	private Rigidbody2D rg2d;
	private Animator anim;
	// Use this for initialization
	void Start () 
	{

		rg2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (isDead == false) 
		{

			if (Input.GetMouseButtonDown (0)) 
			{
				
				rg2d.velocity = Vector2.zero;
				rg2d.AddForce (new Vector2 (0, upforce));
				anim.SetTrigger ("2anim");
			}
		}
	}

	void OnCollisionEnter2D ()
	{
		rg2d.velocity = Vector2.zero;
		isDead = true;
		anim.SetTrigger ("crash");
		GameCtrl.instance.PlaneCrash ();
	}

}

