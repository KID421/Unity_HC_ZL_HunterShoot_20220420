using UnityEngine;
using System.Collections;

/// <summary>
/// 學習迴圈、協同程序 Coroutine：等待
/// while、for 教學
/// do while、foreach
/// </summary>
public class LearnLoop : MonoBehaviour
{
    private void Start()
    {
        // 迴圈：重複執行

        // while 迴圈語法：
        // if (布林值) { 程式 } 執行一次
        // while (布林值) { 程式 } 重複執行直到布林值為 false

        int count = 0;

        while (count < 5)
        {
            print("while 迴圈！" + count);
            count++;
        }

        // for(初始值；條件；迴圈執行後的處理) { 程式 }
        for (int i = 0; i < 5; i++)
        {
            print("for 迴圈！" + i);
        }

        // 協同程序
        // 1. 引用命名空間 System.Collections
        // 2. 定義傳回類型為 IEnumerator 的方法
        // 3. yield return 等待
        // 4. Start Coroutine 啟動
        StartCoroutine(Test());
        StartCoroutine(Loop());
    }

    private IEnumerator Test()
    {
        print("<color=yellow>第一行</color>");
        yield return new WaitForSeconds(1);
        print("<color=yellow>第二行</color>");
    }

    private IEnumerator Loop()
    {
        for (int i = 0; i < 10; i++)
        {
            print("<color=#996611>for 迴圈" + i + "</color>");
            yield return new WaitForSeconds(1);
        }
    }
}
