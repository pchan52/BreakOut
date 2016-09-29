using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomWallScript : MonoBehaviour {

	public GameManager gameManager;
	public GameObject ballPrefab;
	Vector3 placePosition = new Vector3(0f, 0.6f, -7f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//衝突判定 引数はcollision 
	void OnCollisionEnter(Collision collision){
		//collision.gameObjectで衝突相手のゲームオブジェクトを取得
		Destroy (collision.gameObject);

		if (gameManager.life > 0) {

			Instantiate (
				ballPrefab,
				placePosition,
				Quaternion.identity
			);

			gameManager.life--;
		}
		else if (gameManager.life == 0){
			SceneManager.LoadScene("Gameover");
		}
	
	}
}
