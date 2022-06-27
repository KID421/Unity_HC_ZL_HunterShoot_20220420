using UnityEngine;

/// <summary>
/// 學習運算子
/// 1. 數學運算子
/// 2. 比較運算子
/// 3. 邏輯運算子
/// </summary>
public class LearnOperator : MonoBehaviour
{
    private float a = 10;
    private float b = 3;

    private void Start()
    {
        // 加 +
        // 減 -
        // 乘 *
        // 除 /
        // 餘 %
        print("加法：" + (a + b));     // 13
        print("減法：" + (a - b));     // 7
        print("乘法：" + (a * b));     // 30
        print("除法：" + (a / b));     // 3.3333
        print("餘法：" + (a % b));     // 1
    }
}
