using UnityEngine;

// 汽車藍圖 > 物件
// 1. 場景上的遊戲物件
// 2. 添加元件 Add Component
// 3. 選取此類別
public class Car : MonoBehaviour
{
    // ※ 欄位 field 語法 ※
    // 變數 variable
    // 修飾詞 資料類型 欄位自訂名稱 指定 值 結束符號
    // 修飾此資料的存取權限

    // 兩大基本修飾詞
    // 公開：允許外部存取，顯示在屬性面板
    // public
    // 私人：不允許外部存取，不顯示在屬性面板 (預設值，可省略)
    // private

    // 1. Unity 以屬性面板資料為主
    // 2. 還原到程式內的值必須按 ... > Reset

    // 欄位屬性語法
    // [屬性名稱(值)]

    // 1. 提示 Tooltip
    // 2. 標題 Header
    // 3. 範圍 Range ※ 僅限整數與浮點數

    // 程式排版：格式化 Ctrl + K D
    // 重量
    [Range(1, 50)]
    [Tooltip("汽車的重量，單位是噸。")]
    public int weight = 3;
    // 高度
    [Header("汽車的高度"), Range(1, 10)]
    public float height = 6.2f;
    // 品牌
    [Header("汽車的品牌名稱")]
    public string brand = "賓士";
    // 是否有天窗
    [Header("是否有天窗")]
    [Tooltip("設定汽車是否有天窗")]
    public bool hasSkyWindow = true;
}
