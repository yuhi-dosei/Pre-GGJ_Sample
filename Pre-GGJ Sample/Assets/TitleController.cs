using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// タイトル画面を制御するためのスクリプト
public class TitleController : MonoBehaviour
{

	// スコア表示用テキスト
	public Text scoreText;

	// シーンが開始されたら呼ばれる
	void Start()
	{
		// ハイスコアを読み込む
		int highScore = PlayerPrefs.GetInt ("highscore", 0);
		scoreText.text =  "ハイスコア " + highScore;
	}

	// ゲームを始める
	public void StartGame()
	{
		// ゲームシーンに移動する
		SceneManager.LoadScene ("Game");
	}
}
