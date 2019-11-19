# Practice_CSharp_Method_API
練習：C# 方法與 API

## 練習重點：定義方法、學會看 Unity API 並應用於遊戲內

## 練習內容

[![展示影片](http://img.youtube.com/vi/EEsTLq7olak/0.jpg)](http://www.youtube.com/watch?v=EEsTLq7olak "展示影片")

1. 參考【Fork 分支功能教學】將作業下載並完成編輯
2. 作業連結：GitHub 連結
3. 請參考影片建立一個 C# 給狐狸，並定義與影片相同的欄位 (使用標題與範圍)
    1. 移動速度
    2. 剛體 Rigidboyd
    3. 圖片渲染器 SpriteRenderer
4. 定義一個方法，名稱命名為移動
5. 使用 Input.GetAxisRaw API 偵測玩家左右按鍵：[API 連結](https://docs.unity3d.com/ScriptReference/Input.GetAxisRaw.html "Input.GetAxisRaw API")
    1. 水平按鈕為 Horizontal 包含左右方向鍵與 A D
6. 使用 Rigidbody2D.AddForce API 對剛體添加推力：[API 連結](https://docs.unity3d.com/ScriptReference/Rigidbody2D.AddForce.html "Rigidbody2D.AddForce API")
    1. 請使用二維向量 new Vector2(X 方向數值, Y 方向數值)
7. 使用 SpriteRenderer.flipX API 讓狐狸可以翻面：[API 連結](https://docs.unity3d.com/ScriptReference/SpriteRenderer-flipX.html "SpriteRenderer.flipX")
8. 練習完請推送到 GitHub