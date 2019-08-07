using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 敵の動きを制御するためのスクリプト
public class Enemy : MonoBehaviour
{
	// 毎フレーム呼ばれる処理
	void Update()
	{
		transform.Translate(Vector3.down * 0.05f); // 下方向に移動させる
	}

	// 弾や自機に接触したら
    void OnCollisionEnter(Collision collision)
    {
	    // 破壊する
        Destroy(gameObject);

	    // 当たった対象も破壊する
        Destroy(collision.gameObject);

	    // ゲームのスコアを加算する
	    GameObject.FindObjectOfType<GameController> ().Score++;
    }
}
