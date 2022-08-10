using UnityEngine;
using TMPro;
using System.Collections;

namespace KID
{
    /// <summary>
    /// �ˮ`�t�ΡG��s�ˮ`�Ʀr�B�C��H�ΰʺA�ĪG
    /// </summary>
    public class SystemDamage : MonoBehaviour
    {
        #region ���
        /// <summary>
        /// �ˮ`�Ʀr
        /// </summary>
        public float damage;

        [SerializeField, Header("�j�� 100 �C��")]
        private Color colorGratherThan100 = new Color(0.9f, 0.7f, 0.5f);
        [SerializeField, Header("�j�� 200 �C��")]
        private Color colorGratherThan200 = new Color(0.8f, 0.4f, 0.5f);

        private float limitUp;
        private float limitRight;
        private TextMeshProUGUI textDamage;
        #endregion

        private void Awake()
        {
            textDamage = GetComponentInChildren<TextMeshProUGUI>();
            textDamage.text = damage.ToString();

            if (damage >= 200) textDamage.color = colorGratherThan200;
            else if (damage >= 100) textDamage.color = colorGratherThan100;

            limitUp = Random.Range(0.2f, 0.5f);

            int r = Random.Range(0, 2);
            if (r == 0) limitRight = -0.3f;
            else if (r == 1) limitRight = 0.3f;

            StartCoroutine(MovementUp());
            StartCoroutine(MovementRight());
            StartCoroutine(ScaleEffect());
        }

        private IEnumerator MovementUp()
        {
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.up * limitUp;
                yield return new WaitForSeconds(0.01f);
            }

            for (int i = 0; i < 3; i++)
            {
                transform.position -= transform.up * limitUp;
                yield return new WaitForSeconds(0.01f);
            }

            for (int i = 0; i < 10; i++)
            {
                textDamage.color -= new Color(0, 0, 0, 0.1f);
                yield return new WaitForSeconds(0.01f);
            }
        }

        private IEnumerator MovementRight()
        {
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.right * limitRight;
                yield return new WaitForSeconds(0.01f);
            }
        }

        private IEnumerator ScaleEffect()
        {
            for (int i = 0; i < 5; i++)
            {
                transform.localScale += Vector3.one * 0.001f;
                yield return new WaitForSeconds(0.01f);
            }
            for (int i = 0; i < 5; i++)
            {
                transform.localScale -= Vector3.one * 0.001f;
                yield return new WaitForSeconds(0.01f);
            }
        }
    }
}
