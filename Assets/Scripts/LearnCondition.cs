using UnityEngine;

/// <summary>
/// ���� (�P�_��)
/// 1. if
/// 2. switch
/// </summary>
public class LearnCondition : MonoBehaviour
{
    public bool openDoor;
    public int combo;

    private void Start()
    {
        #region if �P�_��
        // if �y�k�G
        // if (���L��) { ���L�ȵ��� true �|���� }
        if (true)
        {
            print("�ڦb�P�_�� if ��");
        }
        #endregion
    }

    private void Update()
    {
        // �p�G openDoor ���� true �N�}���A�_�h�N����
        // �p�G
        // if �y�k�G
        // if (���L��) { ���L�ȵ��� true �|���� }
        // �_�h
        // else { ���L�ȵ��� fals �|���� }
        // else �@�w�n��b if �U��A�����W�ϥ�
        if (openDoor)
        {
            print("�}��");
        }
        else
        {
            print("����");
        }

        // else if () {}
        // �L���ƶq
        // �s���� < 100 �����O + 0%
        // �s���� >= 100 �����O +10%
        // �s���� >= 200 �����O +20%
        if (combo < 100)
        {
            print("�����O + 0%");
        }
        else if (combo >= 200)
        {
            print("�����O + 20%");
        }
        else if (combo >= 100)
        {
            print("�����O + 10%");
        }
    }
}