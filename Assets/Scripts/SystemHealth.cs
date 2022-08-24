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
        #region ���
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
        #endregion

        private SystemSpawn systemSpawn;

        private void Awake()
        {
            hp = dataEnemy.hp;
            textHp.text = hp.ToString();
            systemSpawn = GameObject.Find("�ͦ��Ǫ��t��").GetComponent<SystemSpawn>();
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
        /// ���`
        /// </summary>
        private void Dead()
        {
            // print("���`");
            Destroy(gameObject);
            systemSpawn.totalCountEnemyLive--;
            // print("<color=red>�Ǫ��ƶq�G" + systemSpawn.totalCountEnemyLive + "</color>");
            DropCoin();
        }

        /// <summary>
        /// ��������
        /// </summary>
        private void DropCoin()
        {
            int range = Random.Range(dataEnemy.v2CoinRange.x, dataEnemy.v2CoinRange.y);

            for (int i = 0; i < range; i++)
            {
                float x = Random.Range(-1.5f, 1.5f);
                float z = Random.Range(-1.5f, 1.5f);
                float zAngle = Random.Range(0, 360);

                Instantiate(
                    dataEnemy.goCoin, 
                    transform.position + new Vector3(x, 2.5f, z), 
                    Quaternion.Euler(90, 180, zAngle));
            }
        }
    }
}

