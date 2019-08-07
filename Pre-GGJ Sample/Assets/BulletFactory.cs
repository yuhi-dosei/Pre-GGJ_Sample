using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 弾を生成するためのスクリプト
public class BulletFactory : MonoBehaviour
{
    // 弾のプレハブ（ひな形）
    public GameObject bulletPrefab;

    // タイマー
    private float timer;

    // 毎フレーム呼ばれる処理
    void Update()
    {
        // タイマーを加算する
        timer += Time.deltaTime;

        // スペースキーが押されたら
        if (Input.GetKey(KeyCode.Space))
        {
            // タイマーが0.2秒以上経過していたら
            if (timer >= 0.2f)
            {
                // 弾を発射する
                Shot();

                // タイマーを初期化する
                timer = 0f;
            }
        }
    }

    // 弾を発射する
    void Shot()
    {
        // 弾を生成する
        var bullet = Instantiate(bulletPrefab);

        // 弾の初期位置を設定する
        bullet.transform.position = transform.position + Vector3.up;

        // 3秒後に弾を破壊する
        Destroy(bullet, 3f);
    }
}
