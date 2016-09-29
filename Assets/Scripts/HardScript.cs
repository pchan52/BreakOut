using UnityEngine;
using System.Collections;

public class HardScript : MonoBehaviour {

	public GameManager gameManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	int hitnumber = 2;
	void OnCollisionEnter(){
		hitnumber--;
		if (hitnumber == 0) {
			Destroy (gameObject);
			gameManager.score += 20;
		}
	}
}
