using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace KID
{
    /// <summary>
    /// ��q�t�ΡG��s��q�B�����P���`�B�z
    /// </summary>
    public class SystemHealth : MonoBehaviour
    {
        [SerializeField, Header("�e���ˮ`����")]
        private GameObject goDamage;
        [SerializeField, Header("�Ϥ���q")]
        private Image imgHp;
        [SerializeField, Header("��r��q")]
        private TextMeshProUGUI textHp;
        [SerializeField, Header("�Ǫ����")]
        private DataEnemy dataEnemy;
        [SerializeField, Header("�ĤH�ʵe���")]
        private Animator aniEnemy;

        private float hp;
        private string parDamage = "Ĳ�o����";

        private void Awake()
        {
            hp = dataEnemy.hp;
            textHp.text = hp.ToString();
        }

        // �I���ƥ�
        // 1. ��Ӫ��󥲶����@�ӱa�� Rigidbody
        // 2. ��Ӫ��󥲶����I���� Collider
        // 3. �O�_���Ŀ� Is Trigger
        // 3-1 ��̳��S���Ŀ� Is Trigger �ϥ� OnCollision
        private void OnCollisionEnter(Collision collision)
        {
            GetDamage();
        }

        /// <summary>
        /// ����
        /// </summary>
        private void GetDamage()
        {
            hp -= 50;
            textHp.text = hp.ToString();
            imgHp.fillAmount = hp / dataEnemy.hp;
            aniEnemy.SetTrigger(parDamage);

            if (hp <= 0) Dead();
        }

        /// <summary>
        /// ���`
        /// </summary>
        private void Dead()
        {
            print("���`");
        }
    }
}

