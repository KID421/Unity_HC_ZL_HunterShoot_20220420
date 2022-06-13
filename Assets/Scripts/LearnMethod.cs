using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    // 自訂方法
    // 需要呼叫才會執行

    // Unity 的入口
    // 開始事件 (藍色名稱)
    // 播放遊戲後會執行一次
    // 初始化設定：初始金額、三條命等等等
    private void Start()
    {
        // 呼叫方法
        // 方法名稱()；
        Test();
        PrintColorText();

        print("傳回 10 方法結果：" + ReturnTen());
        print("商品總價：" + CalculatePrice());

        Shoot("火球");                  // 沒有填參數會以預設值執行
        Shoot("電球");
        Shoot("冰球", "滋滋滋");         // 覆蓋參數
        Shoot("雪球", "白色雪花");            // 不指定執行結果錯誤
        Shoot("雪球", effect: "白色雪花");    // 雪球，咻咻咻，指定 參數名稱: 白色雪花

        // 近距離攻擊
        Attack(50);
        // 遠距離攻擊
        Attack(20, "火球");
    }

    #region 方法練習
    // 方法語法
    // 修飾詞 傳回類型 方法自訂名稱 (參數1, 參數2, ...) { 方法內容 }
    // 無傳回 void
    // 方法名稱 Unity 習慣用大寫開頭
    private void Test()
    {
        // 輸出(輸出訊息)；
        print("哈囉，沃德 :D");
    }

    private void PrintColorText()
    {
        // Rich text

        print("<color=yellow>黃色訊息</color>");
        print("<color=red>紅色訊息</color>");
        print("<size=20><color=#003399>藍色訊息</color></size>");
    }

    // 傳回方法
    // 必須搭配 return
    private int ReturnTen()
    {
        // 傳回 資料 (此資料類型必須與傳回類型相同)
        return 10;
    }

    // 商店系統：99 元，計算全部的商品價格
    public int countProduct = 10;
    public int countPrice = 99;

    private int CalculatePrice()
    {
        return countProduct * countPrice;
    }
    #endregion

    // 發射火球、發射電球
    // 播放音效
    private void ShootFire()
    {
        print("發射火球");
        print("播放音效");
    }

    private void ShootLighting()
    {
        print("發射電球");
        print("播放音效");
    }

    // 參數語法：參數類型 參數名稱 指定 預設值
    // 有預設值的參數必須放在最右邊
    private void Shoot(string type, string sound = "咻咻咻", string effect = "煙霧")
    {
        print("發射：" + type);
        print("音效：" + sound);
        print("特效：" + effect);
    }

    // 方法的多載 overload
    // 定義：
    // 1. 相同名稱的方法
    // 2. 有不同數量的參數或者不同類型的參數
    private void TestMethod()
    {

    }

    private void TestMethod(int number)
    {

    }

    private void Attack(float atk)
    {
        print("近距離攻擊，攻擊力：" + atk);
    }

    private void Attack(float atk, string ball)
    {
        print("遠距離攻擊，攻擊力：" + atk);
        print("發射物件：" + ball);
    }
}
