using UnityEngine;

namespace KID
{
    /// <summary>
    /// 金幣系統：忽略碰撞、飛到金幣位置
    /// </summary>
    public class SystemCoin : MonoBehaviour
    {
        [SerializeField, Header("延遲飛行"), Range(0, 2)]
        private float delayFly = 1.5f;
        [SerializeField, Header("飛行速度"), Range(0, 10)]
        private float speed = 1.5f;

        /// <summary>
        /// 金幣要前往的位置
        /// </summary>
        private Transform traCoinFlyTo;
        /// <summary>
        /// 開始飛行
        /// </summary>
        private bool startFly;

        private ManagerCoin managerCoin;

        private void Awake()
        {
            Physics.IgnoreLayerCollision(6, 3);     // 金幣、彈珠忽略碰撞
            Physics.IgnoreLayerCollision(6, 6);     // 金幣、金幣忽略碰撞
            Physics.IgnoreLayerCollision(6, 7);     // 金幣、怪物忽略碰撞

            traCoinFlyTo = GameObject.Find("金幣要前往的位置").transform;
            managerCoin = GameObject.Find("金幣管理器").GetComponent<ManagerCoin>();

            Invoke("StartFly", delayFly);
        }

        private void Update()
        {
            Fly();
        }

        /// <summary>
        /// 開始飛行
        /// </summary>
        private void StartFly()
        {
            startFly = true;
        }

        /// <summary>
        /// 飛行
        /// </summary>
        private void Fly()
        {
            if (!startFly) return;

            // 插值：將 A B 兩個數值抓出中間的指定位置
            Vector3 traCoin = transform.position;
            Vector3 traCoinTo = traCoinFlyTo.position;

            traCoin = Vector3.Lerp(traCoin, traCoinTo, speed * Time.deltaTime);
            transform.position = traCoin;

            DestoryCoin();
        }

        /// <summary>
        /// 刪除金幣
        /// </summary>
        private void DestoryCoin()
        {
            float dis = Vector3.Distance(transform.position, traCoinFlyTo.position);

            if (dis < 2.5f)
            {
                managerCoin.AddCoinAndUpdateUI();
                Destroy(gameObject);
            }
        }
    }
}
