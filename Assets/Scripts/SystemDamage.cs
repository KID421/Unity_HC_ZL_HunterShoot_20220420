using UnityEngine;
using TMPro;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 傷害系統：更新傷害數字、顏色以及動態效果
    /// </summary>
    public class SystemDamage : MonoBehaviour
    {
        #region 資料
        /// <summary>
        /// 傷害數字
        /// </summary>
        public float damage;

        [SerializeField, Header("大於 100 顏色")]
        private Color colorGratherThan100 = new Color(0.9f, 0.7f, 0.5f);
        [SerializeField, Header("大於 200 顏色")]
        private Color colorGratherThan200 = new Color(0.8f, 0.4f, 0.5f);

        private float limitUp;
        private float limitRight;
        private TextMeshProUGUI textDamage;
        #endregion

        // 快速選取同一個詞的方式 Alt + Shift + >
        [SerializeField, Header("效果間隔"), Range(0, 0.1f)]
        private float interval = 0.025f;

        private void Start()
        {
            textDamage = GetComponentInChildren<TextMeshProUGUI>();
            textDamage.text = damage.ToString();

            if (damage >= 200) textDamage.color = colorGratherThan200;
            else if (damage >= 100) textDamage.color = colorGratherThan100;

            limitUp = Random.Range(0.2f, 0.3f);

            int r = Random.Range(0, 2);
            if (r == 0) limitRight = -0.25f;
            else if (r == 1) limitRight = 0.25f;

            StartCoroutine(MovementUp());
            StartCoroutine(MovementRight());
            StartCoroutine(ScaleEffect());
        }

        private IEnumerator MovementUp()
        {
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.up * limitUp;
                yield return new WaitForSeconds(interval);
            }

            for (int i = 0; i < 3; i++)
            {
                transform.position -= transform.up * limitUp;
                yield return new WaitForSeconds(interval);
            }

            for (int i = 0; i < 10; i++)
            {
                textDamage.color -= new Color(0, 0, 0, 0.1f);
                yield return new WaitForSeconds(interval);
            }
        }

        private IEnumerator MovementRight()
        {
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.right * limitRight;
                yield return new WaitForSeconds(interval);
            }
        }

        private IEnumerator ScaleEffect()
        {
            for (int i = 0; i < 5; i++)
            {
                transform.localScale += Vector3.one * 0.001f;
                yield return new WaitForSeconds(interval);
            }
            for (int i = 0; i < 5; i++)
            {
                transform.localScale -= Vector3.one * 0.001f;
                yield return new WaitForSeconds(interval);
            }
        }
    }
}
