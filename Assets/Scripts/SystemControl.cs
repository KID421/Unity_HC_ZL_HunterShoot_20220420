using UnityEngine;
using System.Collections;

// 命名空間 namespace 空間名稱 { 該空間的內容 }
namespace KID
{
    /// <summary>
    /// 玩家控制系統
    /// 物件旋轉、發射彈珠
    /// </summary>
    public class SystemControl : MonoBehaviour
    {
        #region 資料
        // GameObject 遊戲物件
        // 存放階層面板內或者專案內的物件
        [Header("箭頭")]
        public GameObject arrow;
        [Header("旋轉速度"), Range(0, 500)]
        public float speedTurn = 10.5f;
        [Header("彈珠預製物")]
        public GameObject marble;
        [Header("彈珠可以發射的總數"), Range(0, 100)]
        public int canShootMarbleTotal = 15;
        [Header("彈珠生成點")]
        public Transform traSpawnPoint;
        [Header("攻擊參數名稱")]
        public string parAttack = "觸發攻擊";
        [Header("彈珠發射速度"), Range(0, 5000)]
        public float speedMarble = 1000;
        [Header("彈珠發射間隔"), Range(0, 2)]
        public float intervalMarble = 0.5f;

        public Animator ani;
        #endregion

        #region 事件
        // Awake 在 Start 之前執行一次
        private void Awake()
        {
            ani = GetComponent<Animator>();
        }

        private void Update()
        {
            ShootMarble();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 旋轉角色，讓角色面向滑鼠的位置
        /// </summary>
        private void TurnCharacter()
        {

        }

        /// <summary>
        /// 發射彈珠，根據總數發射彈珠物件
        /// </summary>
        private void ShootMarble()
        {
            // 按下 滑鼠左鍵 顯示 箭頭
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                arrow.SetActive(true);
            }
            // 放開 滑鼠左鍵 隱藏箭頭 生成並發射彈珠
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                // print("放開左鍵！");
                arrow.SetActive(false);
                StartCoroutine(SpawnMarble());
            }
        }

        /// <summary>
        /// 生成彈珠附帶間隔時間
        /// </summary>
        private IEnumerator SpawnMarble()
        {
            for (int i = 0; i < canShootMarbleTotal; i++)
            {
                ani.SetTrigger(parAttack);

                // Object 類別可省略不寫
                // 直接透過 Object 成員名稱使用
                // 生成(彈珠)；
                // Quaternion.identity 零度角
                GameObject tempMarble = Instantiate(marble, traSpawnPoint.position, Quaternion.identity);
                // 暫存彈珠 取得剛體元件 添加推力 (角色.前方 * 速度)
                // transform.forward 角色的前方
                tempMarble.GetComponent<Rigidbody>().AddForce(transform.forward * speedMarble);

                yield return new WaitForSeconds(intervalMarble);
            }
        }

        /// <summary>
        /// 回收彈珠
        /// </summary>
        private void RecycleMarble()
        {

        }
        #endregion
    }
}
