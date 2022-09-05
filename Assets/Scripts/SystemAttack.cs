using UnityEngine;

namespace KID
{
    /// <summary>
    /// �����t��
    /// </summary>
    public class SystemAttack : MonoBehaviour
    {
        [SerializeField, Header("�������")]
        private DataAttack dataAttack;

        /// <summary>
        /// �����ƭ�
        /// </summary>
        public float valueAttack;

        private void Awake()
        {
            // �����ƭ� = �����O + �d��(-�����B�ʡA+�����B��)
            // �Ҧp�G�����ƭ� = 100 + (-10, 10)�G�d�򸨦b 90 ~ 110
            valueAttack = dataAttack.attack +
                Random.Range(-dataAttack.attackFloat, dataAttack.attackFloat);
            
            valueAttack = Mathf.Floor(valueAttack);
        }
    }
}
