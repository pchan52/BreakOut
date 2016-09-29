using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	void  OnGUI (){

		GUIStyle guiStyle = new GUIStyle();
		GUIStyleState styleState = new GUIStyleState();

		styleState.textColor = Color.black;

		guiStyle.normal = styleState;
		guiStyle.fontSize = 120;

		GUI.Label( new Rect(200, 300, 300, 100), "Game Over !!", guiStyle);
	}

}