﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fox : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"),Range(0,50)]
    public  int speed;
    public Rigidbody2D Rig;
    public SpriteRenderer Sr;

    #endregion

    #region 事件

    private void Start()
    {

        Move();

         
    }

    #endregion
    private void Update()
    {
        print("左右按鍵:" + Input.GetAxisRaw("Horizontal"));
    }
    #region 方法

    private void Move()
    {
        print("左右按鍵:" + Input.GetAxisRaw("Horizontal"));


        //定義一個方法，名稱命名為移動
        //使用 Input.GetAxisRaw API 偵測玩家左右按鍵        
        //print(" 按下按鍵:" + Input.GetAxisRaw("Horizontal"));
        //a.水平按鈕為 Horizontal 包含左右方向鍵與 A D

        //使用 Rigidbody2D.AddForce API 對剛體添加推力
        //a.請使用二維向量 new Vector2(X 方向數值, Y 方向數值)

        Rig = gameObject.AddComponent<Rigidbody2D>();
       // Rig.AddForce = new Vector2(0, 400);
        
        //Rig.AddForce = new Vector2(0, 400);

        //使用 SpriteRenderer.flipX API 讓狐狸可以翻面

    }
    #endregion
}
