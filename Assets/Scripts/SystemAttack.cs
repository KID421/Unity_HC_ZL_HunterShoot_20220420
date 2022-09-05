using UnityEngine;

namespace KID
{
    /// <summary>
    /// 攻擊系統
    /// </summary>
    public class SystemAttack : MonoBehaviour
    {
        [SerializeField, Header("攻擊資料")]
        private DataAttack dataAttack;

        /// <summary>
        /// 攻擊數值
        /// </summary>
        public float valueAttack;

        private void Awake()
        {
            // 攻擊數值 = 攻擊力 + 範圍(-攻擊浮動，+攻擊浮動)
            // 例如：攻擊數值 = 100 + (-10, 10)：範圍落在 90 ~ 110
            valueAttack = dataAttack.attack +
                Random.Range(-dataAttack.attackFloat, dataAttack.attackFloat);
            
            valueAttack = Mathf.Floor(valueAttack);
        }
    }
}
