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

        print("�Ǧ^ 10 ��k���G�G" + ReturnTen());
        print("�ӫ~�`���G" + CalculatePrice());

        Shoot("���y");                  // �S����ѼƷ|�H�w�]�Ȱ���
        Shoot("�q�y");
        Shoot("�B�y", "������");         // �л\�Ѽ�
        Shoot("���y", "�զ⳷��");            // �����w���浲�G���~
        Shoot("���y", effect: "�զ⳷��");    // ���y�A�������A���w �ѼƦW��: �զ⳷��

        // ��Z������
        Attack(50);
        // ���Z������
        Attack(20, "���y");
    }

    #region ��k�m��
    // ��k�y�k
    // �׹��� �Ǧ^���� ��k�ۭq�W�� (�Ѽ�1, �Ѽ�2, ...) { ��k���e }
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
        print("<size=20><color=#003399>�Ŧ�T��</color></size>");
    }

    // �Ǧ^��k
    // �����f�t return
    private int ReturnTen()
    {
        // �Ǧ^ ��� (��������������P�Ǧ^�����ۦP)
        return 10;
    }

    // �ө��t�ΡG99 ���A�p��������ӫ~����
    public int countProduct = 10;
    public int countPrice = 99;

    private int CalculatePrice()
    {
        return countProduct * countPrice;
    }
    #endregion

    // �o�g���y�B�o�g�q�y
    // ���񭵮�
    private void ShootFire()
    {
        print("�o�g���y");
        print("���񭵮�");
    }

    private void ShootLighting()
    {
        print("�o�g�q�y");
        print("���񭵮�");
    }

    // �Ѽƻy�k�G�Ѽ����� �ѼƦW�� ���w �w�]��
    // ���w�]�Ȫ��Ѽƥ�����b�̥k��
    private void Shoot(string type, string sound = "������", string effect = "����")
    {
        print("�o�g�G" + type);
        print("���ġG" + sound);
        print("�S�ġG" + effect);
    }

    // ��k���h�� overload
    // �w�q�G
    // 1. �ۦP�W�٪���k
    // 2. �����P�ƶq���ѼƩΪ̤��P�������Ѽ�
    private void TestMethod()
    {

    }

    private void TestMethod(int number)
    {

    }

    private void Attack(float atk)
    {
        print("��Z�������A�����O�G" + atk);
    }

    private void Attack(float atk, string ball)
    {
        print("���Z�������A�����O�G" + atk);
        print("�o�g����G" + ball);
    }
}
