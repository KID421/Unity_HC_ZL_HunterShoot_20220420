using UnityEngine;

/// <summary>
/// �ǲ߰j��
/// while�Bfor �о�
/// while do�Bforeach
/// </summary>
public class LearnLoop : MonoBehaviour
{
    private void Start()
    {
        // �j��G���ư���

        // while �j��y�k�G
        // if (���L��) { �{�� } ����@��
        // while (���L��) { �{�� } ���ư��檽�쥬�L�Ȭ� false

        int count = 0;

        while (count < 5)
        {
            print("while �j��I" + count);
            count++;
        }
    }
}
