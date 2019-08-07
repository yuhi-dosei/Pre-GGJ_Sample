using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーボード操作で自機を動かすためのスクリプト
public class Move : MonoBehaviour
{

    // 毎フレーム呼ばれる処理
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * 0.05f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * 0.05f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * 0.05f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * 0.05f);
        }
    }
}
