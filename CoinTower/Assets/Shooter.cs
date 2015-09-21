// ----- ----- ----- ----- -----
//
// Shooter
//
// 作成日：
// 作成者：
//
// <概要>
//
//
// ----- ----- ----- ----- -----

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[AddComponentMenu("Coin/Shooter")]
public class Shooter : MonoBehaviour
{
	#region 変数

    [SerializeField]
    private GameObject coin;

    #endregion


    #region プロパティ



    #endregion


    #region メソッド

	// 初期化処理
    void Awake()
    {

    }

    // 更新前処理
    void Start()
    {

    }

    // 更新処理
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(coin,transform.position,Quaternion.identity);
        }
    }
	#endregion
}
