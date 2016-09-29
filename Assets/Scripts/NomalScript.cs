using UnityEngine;
using System.Collections;

public class NomalScript : MonoBehaviour {

	public GameManager gameManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	衝突判定 gameObjectはアタッチしたもの
	void OnCollisionEnter(){
		Destroy (gameObject);
		gameManager.score += 10;
	}
}
