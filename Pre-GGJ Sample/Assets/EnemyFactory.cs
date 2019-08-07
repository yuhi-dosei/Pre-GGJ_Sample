using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 敵を生成するためのスクリプト
public class EnemyFactory : MonoBehaviour
{
	// 敵のプレハブ（ひな形）
	public GameObject enemyPrefab;

	// タイマー
	private float timer;

	// 毎フレーム呼ばれる処理
	void Update()
	{
		// タイマーを加算する
		timer += Time.deltaTime;

		// タイマーが1秒経過していたら
		if (timer >= 1f)
		{
			// 敵を生成する
			Create();

			// タイマーを初期化する
			timer = 0f;
		}
	}

	// 敵を生成する
	void Create()
	{
		// プレハブから敵のオブジェクトを生成
		var obj = Instantiate(enemyPrefab);

		// -5f ～ 5f の間でランダムな値を取得
		var x = Random.Range(-5f, 5f);

		// 敵の位置を設定
		obj.transform.position = new Vector3(x, 5f, 0f);

		// 5秒後に自動的に破棄する
		Destroy(obj, 5f);
	}

}
