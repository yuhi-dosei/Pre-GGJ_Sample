using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 弾を制御するためのスクリプト
public class Bullet : MonoBehaviour
{
    // 毎フレーム呼ばれる処理
    void Update()
    {
        // 弾を上に進める
        transform.Translate(Vector3.up * 0.1f);
    }
}
