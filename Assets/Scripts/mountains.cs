using UnityEngine;
using System.Collections;

public class mountains : MonoBehaviour {

	private void OnTriggerEnter2D (Collider2D other){
	
		if (other.GetComponent<plane> () != null) {
		
			GameCtrl.instance.BirdScored ();
		}
	}
}
