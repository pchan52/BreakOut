using UnityEngine;
using System.Collections;

public class PenetrateScript : MonoBehaviour {

	public GameManager gameManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//接触判定
	void OnTriggerEnter(){
		Destroy (gameObject);	
		gameManager.score += 10;
	}
}
