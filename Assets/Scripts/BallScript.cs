using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	float speed = 15.0f;

	void  Update (){
//		Jumpに対応するkeyが押して離した かつ 
		if (Input.GetButtonUp("Jump") && GetComponent<Rigidbody>().velocity == new Vector3(0, 0, 0)){
//			x軸とz軸の合成ベクトルに対してspeedをかけ合わせ大きさがspeedの方向ベクトルに対して力を加える
			GetComponent<Rigidbody>().AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
		}
	}

	//衝突したら正規化しボールの速度を一定に保つ
	void OnCollisionEnter(){
		Rigidbody rigidbody = GetComponent<Rigidbody> ();
		rigidbody.velocity = rigidbody.velocity.normalized * 15;
	}
}