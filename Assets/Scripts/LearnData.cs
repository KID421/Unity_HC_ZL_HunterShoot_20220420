// 單行註解，說明、標記，KID 2022.05.16
/*
 * 多行註解
 * 多行註解
 */ 

// 藍色 保留字
// 白色 名稱
// 綠色 資料類型
using UnityEngine;

// 修飾詞 類別(藍圖) 類別名稱 繼承(物件導向程式設計 OOP 三大原則)
public class LearnData : MonoBehaviour
{
    // LearnData 類別成員區域

    // 儲存資料方式：
    // 欄位 field
    // 儲存各種資料
    // 欄位語法
    // 資料類型 欄位自訂名稱 指定 值 結束符號
    // 指定 值 可以省略，會以預設值，數值預設值 0，字串空，布林值 false 沒有
    // 定義一筆整數資料 名稱叫做 hp
    int hp;

    // 資料類型：四大基本類型
    // 整　數：保存正負沒有小數點的資料 int
    // 浮點數：保存正負有小數點的資料 float
    // 字　串：保存文字資訊 string
    // 布林值：保存有、沒有 bool

    // = 指定符號，將右邊的值賦予左邊
    int lv = 87;
    // 浮點數必須加上 f 後綴，大小 F 皆可
    float exp = 0.003f;
    // 字串必須使用雙引號
    string playerName = "@KID421屁孩";
    // true 有，false 沒有
    bool hasCureSkill = true;

    // Clean Code 無瑕的程式
}

// 非 LearnData 類別成員區域