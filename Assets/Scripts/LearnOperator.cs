using UnityEngine;

/// <summary>
/// �ǲ߹B��l
/// 1. �ƾǹB��l
/// 2. ����B��l
/// 3. �޿�B��l
/// </summary>
public class LearnOperator : MonoBehaviour
{
    private float a = 10;
    private float b = 3;

    private void Start()
    {
        // �[ +
        // �� -
        // �� *
        // �� /
        // �l %
        print("�[�k�G" + (a + b));     // 13
        print("��k�G" + (a - b));     // 7
        print("���k�G" + (a * b));     // 30
        print("���k�G" + (a / b));     // 3.3333
        print("�l�k�G" + (a % b));     // 1
    }
}
