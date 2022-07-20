using UnityEngine;

/// <summary>
/// 學習迴圈
/// while、for 教學
/// while do、foreach
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
    }
}
