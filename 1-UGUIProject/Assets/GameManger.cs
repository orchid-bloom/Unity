using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour {

	public void OnStartGame(string sceneName) {
		Application.LoadLevel (sceneName);
	}

//	public void OnStartGame(int index) {
//		Application.LoadLevel (index);
//	}
}
