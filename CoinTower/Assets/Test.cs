﻿// ----- ----- ----- ----- -----
//
// Test
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

[AddComponentMenu("MyScript/Test")]
public class Test : MonoBehaviour
{
	#region 変数

    [SerializeField]
    private bool frag;

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
        Debug.Assert(frag,"frag is true!");
    }

    // 更新処理
    void Update()
    {
        //タンバリン
    }
	#endregion
}
