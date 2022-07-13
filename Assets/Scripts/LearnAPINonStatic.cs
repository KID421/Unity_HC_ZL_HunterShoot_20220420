using UnityEngine;

/// <summary>
/// 學習 非靜態 API
/// API 文件上沒有 static
/// </summary>
public class LearnAPINonStatic : MonoBehaviour
{
    public Transform traA;
    public Light lightA;
    public Transform traB;

    private void Start()
    {
        // 非靜態屬性 properties
        // 1. 取得 get
        // 條件：
        // - 該類別類型欄位
        // - 實體物件 帶有此類別的元件
        // - 欄位存放該實體物件
        // 欄位名稱.非靜態屬性名稱
        print("A 物件的座標：" + traA.position);
        print("燈光顏色：" + lightA.color);

        // 2. 設定 set
        // 欄位名稱.非靜態屬性名稱 指定 值；
        traA.position = new Vector3(1.57f, 0.5f, -15);
        lightA.color = new Color(1, 0, 0);
    }

    private void Update()
    {
        // 非靜態方法 methods
        // 3. 使用
        // 欄位名稱.非靜態方法名稱(對應引數)
        traB.Rotate(0, 10, 0);
    }
}
