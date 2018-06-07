using UnityEngine;
using System.Collections;

public class mountainpool : MonoBehaviour {

	public int mountainPoolSize = 5;
	public GameObject mountainPrefab;
	public float spawnRate = 4f;
	public float mountainmin = -2f;
	public float mountainmax = 3.5f;

	private GameObject[] mountains;
	private Vector2 objectPoolPosition = new Vector2 (-15f, -25f);
	private float timeSinceLastSpawned;
	private float spawnXPosition = 10f;
	private int currentMountain = 0;

	// Use this for initialization
	void Start () {

		mountains = new GameObject[mountainPoolSize];
		for (int i = 0; i < mountainPoolSize; i++) {

			mountains [i] = (GameObject)Instantiate (mountainPrefab, objectPoolPosition, Quaternion.identity);
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		timeSinceLastSpawned += Time.deltaTime;

		if (GameCtrl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate) {
		
		
			timeSinceLastSpawned = 0;
			float spawnYPosition = Random.Range (mountainmin, mountainmax);
			mountains [currentMountain].transform.position = new Vector2 (spawnXPosition, spawnYPosition);
			currentMountain++;
			if (currentMountain >= mountainPoolSize){

				currentMountain =  0; 
			}
		}
	
	}
}
