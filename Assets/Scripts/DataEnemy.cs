using UnityEngine;

namespace KID
{
    // ScriptableObject �}���ƪ���G�}�����e�ܦ������Ʀs��b Project ��
    // �����f�t CreateAssetMenu
    [CreateAssetMenu(menuName = "KID/Data Enemy", fileName = "Data Enemy")]
    public class DataEnemy : ScriptableObject
    {
        [Header("��q"), Range(0, 10000)]
        public float hp;
        [Header("�ˮ`"), Range(0, 10000)]
        public float damage;
        [Header("���������w�s��")]
        public GameObject goCoin;
        [Header("���������d��")]
        public Vector2Int v2CoinRange;
    }
}
