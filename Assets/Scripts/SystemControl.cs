using UnityEngine;

// �R�W�Ŷ� namespace �Ŷ��W�� { �ӪŶ������e }
namespace KID
{
    /// <summary>
    /// ���a����t��
    /// �������B�o�g�u�]
    /// </summary>
    public class SystemControl : MonoBehaviour
    {
        #region ���
        // GameObject �C������
        // �s�񶥼h���O���Ϊ̱M�פ�������
        [Header("�b�Y")]
        public GameObject arrow;
        [Header("����t��"), Range(0, 500)]
        public float speedTurn = 10.5f;
        [Header("�u�]�w�s��")]
        public GameObject marble;
        [Header("�u�]�i�H�o�g���`��"), Range(0, 100)]
        public int canShootMarbleTotal = 15;
        [Header("�u�]�ͦ��I")]
        public Transform traSpawnPoint;
        [Header("�����ѼƦW��")]
        public string parAttack = "Ĳ�o����";

        public Animator ani;
        #endregion

        #region �ƥ�
        private void Update()
        {
            ShootMarble();
        }
        #endregion

        #region ��k
        /// <summary>
        /// ���ਤ��A�����⭱�V�ƹ�����m
        /// </summary>
        private void TurnCharacter()
        {

        }

        /// <summary>
        /// �o�g�u�]�A�ھ��`�Ƶo�g�u�]����
        /// </summary>
        private void ShootMarble()
        {
            // ��} �ƹ����� �ͦ��õo�g�u�]
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                print("��}����I");

                // Object ���O�i�ٲ����g
                // �����z�L Object �����W�٨ϥ�
                // �ͦ�(�u�])�F
                // Quaternion.identity �s�ר�
                Instantiate(marble, traSpawnPoint.position, Quaternion.identity);
            }
        }

        /// <summary>
        /// �^���u�]
        /// </summary>
        private void RecycleMarble()
        {

        }
        #endregion
    }
}
