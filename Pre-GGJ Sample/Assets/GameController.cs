using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// ゲーム画面を制御するためのスクリプト
public class GameController : MonoBehaviour
{
	// スコア表示用のテキスト
	public Text scoreText;

	// ゲームオーバー表示用のパネル
	public GameObject gameOverPanel;

	// スコア
	int score;

	// スコアのプロパティ
	public int Score
	{
		get
		{
			return score;
		}

		set
		{
			// スコアをセットすると、テキスト表示も更新される
			score = value;
			scoreText.text =  "スコア " + score;
		}
	}

	// ゲームオーバー表示
	public void GameOver()
	{
		// ゲームオーバーアニメーションを表示する
		StartCoroutine (GameOverCoroutine ());
	}

	// ゲームオーバーアニメーション
	IEnumerator GameOverCoroutine()
	{
		// ゲームオーバーパネルを表示する
		gameOverPanel.SetActive (true);

		// 5秒待つ
		yield return new WaitForSeconds (5f);

		// タイトルに移動する
		SceneManager.LoadScene ("Title");

		// セーブされているスコアを取得する
		int highScore = PlayerPrefs.GetInt ("highscore", 0);

		// セーブされているスコアよりも現在のスコアが高ければ
		// スコアを上書き保存する
		if(score > highScore)
			PlayerPrefs.SetInt ("highscore", score);
	}

	// テストコード
//	void Update() {
//		Score++;
//	}

}
