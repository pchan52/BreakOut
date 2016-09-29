using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	float accel = 100.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//GetComponent<クラス
		GetComponent<Rigidbody> ().AddForce (transform.right * Input.GetAxisRaw ("Horizontal") * accel, ForceMode.Impulse);
	}
}
