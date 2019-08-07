using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 自機を制御するためのスクリプト
public class Player : MonoBehaviour
{

	// 破壊されたら呼ばれるメソッド
	void OnDestroy()
	{
		// 自機が破壊されたらゲームオーバー画面を表示する
		GameObject.FindObjectOfType<GameController> ().GameOver();
	}

}
