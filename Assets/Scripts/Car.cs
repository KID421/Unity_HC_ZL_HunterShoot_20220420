using UnityEngine;

// �T���Ź� > ����
// 1. �����W���C������
// 2. �K�[���� Add Component
// 3. ��������O
public class Car : MonoBehaviour
{
    // �� ��� field �y�k ��
    // �ܼ� variable
    // �׹��� ������� ���ۭq�W�� ���w �� �����Ÿ�
    // �׹�����ƪ��s���v��

    // ��j�򥻭׹���
    // ���}�G���\�~���s���A��ܦb�ݩʭ��O
    // public
    // �p�H�G�����\�~���s���A����ܦb�ݩʭ��O (�w�]�ȡA�i�ٲ�)
    // private

    // 1. Unity �H�ݩʭ��O��Ƭ��D
    // 2. �٭��{�������ȥ����� ... > Reset

    // ����ݩʻy�k
    // [�ݩʦW��(��)]

    // 1. ���� Tooltip
    // 2. ���D Header
    // 3. �d�� Range �� �ȭ���ƻP�B�I��

    // �{���ƪ��G�榡�� Ctrl + K D
    // ���q
    [Range(1, 50)]
    [Tooltip("�T�������q�A���O���C")]
    public int weight = 3;
    // ����
    [Header("�T��������"), Range(1, 10)]
    public float height = 6.2f;
    // �~�P
    [Header("�T�����~�P�W��")]
    public string brand = "���h";
    // �O�_���ѵ�
    [Header("�O�_���ѵ�")]
    [Tooltip("�]�w�T���O�_���ѵ�")]
    public bool hasSkyWindow = true;
}
