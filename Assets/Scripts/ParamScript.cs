using UnityEngine;
using System.Collections;

public class ParamScript : MonoBehaviour {

	public GameManager gameManager;
	public GUIStyle guiStyle;

	void  OnGUI (){     

//		new Rect(x,y,幅，高さ)
		Rect position1 = new Rect (10, 10, 200, 40);
		Rect position2 = new Rect (10, 50, 200, 40);
		Rect position3 = new Rect (10, 120, 200, 40);
		Rect position4 = new Rect (10, 160, 200, 40);


//		GUI.Label(position:,Texture,guiStyle)
		GUI.Label ( position1, "スコア", guiStyle);
		GUI.Label ( position2, gameManager.score.ToString(), guiStyle);
		GUI.Label ( position3, "残機数", guiStyle);
		GUI.Label ( position4, gameManager.life.ToString(), guiStyle);
	}
}