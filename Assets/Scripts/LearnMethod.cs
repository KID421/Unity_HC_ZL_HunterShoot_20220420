using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    // �ۭq��k
    // �ݭn�I�s�~�|����

    // Unity ���J�f
    // �}�l�ƥ� (�Ŧ�W��)
    // ����C����|����@��
    // ��l�Ƴ]�w�G��l���B�B�T���R������
    private void Start()
    {
        // �I�s��k
        // ��k�W��()�F
        Test();
        PrintColorText();
    }

    // ��k�y�k
    // �׹��� �Ǧ^���� ��k�ۭq�W�� () { ��k���e }
    // �L�Ǧ^ void
    // ��k�W�� Unity �ߺD�Τj�g�}�Y
    private void Test()
    {
        // ��X(��X�T��)�F
        print("���o�A�U�w :D");
    }

    private void PrintColorText()
    {
        // Rich text

        print("<color=yellow>����T��</color>");
        print("<color=red>����T��</color>");
        print("<size=50><color=#003399>�Ŧ�T��</color></size>");
    }
}
