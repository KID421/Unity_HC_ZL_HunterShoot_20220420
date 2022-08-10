using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace KID
{
    /// <summary>
    /// 血量系統：更新血量、介面與死亡處理
    /// </summary>
    public class SystemHealth : MonoBehaviour
    {
        [SerializeField, Header("畫布傷害物件")]
        private GameObject goDamage;
        [SerializeField, Header("圖片血量")]
        private Image imgHp;
        [SerializeField, Header("文字血量")]
        private TextMeshProUGUI textHp;
        [SerializeField, Header("怪物資料")]
        private DataEnemy dataEnemy;
        [SerializeField, Header("敵人動畫控制器")]
        private Animator aniEnemy;

        private float hp;
        private string parDamage = "觸發受傷";

        private void Awake()
        {
            hp = dataEnemy.hp;
            textHp.text = hp.ToString();
        }

        // 碰撞事件
        // 1. 兩個物件必須有一個帶有 Rigidbody
        // 2. 兩個物件必須有碰撞器 Collider
        // 3. 是否有勾選 Is Trigger
        // 3-1 兩者都沒有勾選 Is Trigger 使用 OnCollision
        private void OnCollisionEnter(Collision collision)
        {
            GetDamage();
        }

        /// <summary>
        /// 受傷
        /// </summary>
        private void GetDamage()
        {
            float getDamage = 50;
            hp -= getDamage;
            textHp.text = hp.ToString();
            imgHp.fillAmount = hp / dataEnemy.hp;
            aniEnemy.SetTrigger(parDamage);
            Vector3 pos = transform.position + Vector3.up;
            SystemDamage tempDamage = Instantiate(goDamage, pos, Quaternion.Euler(45, 0, 0)).GetComponent<SystemDamage>();
            tempDamage.damage = getDamage;

            if (hp <= 0) Dead();
        }

        /// <summary>
        /// 死亡
        /// </summary>
        private void Dead()
        {
            print("死亡");
        }
    }
}

