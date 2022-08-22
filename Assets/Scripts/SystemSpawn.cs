using UnityEngine;
using System.Collections.Generic;   // 資料結構 清單 List
using System.Linq;                  // 查詢語言

namespace KID
{
    /// <summary>
    /// 生成怪物系統
    /// </summary>
    public class SystemSpawn : MonoBehaviour
    {
        #region 資料
        // [] 陣列
        // SerializeField 將私人欄位顯示
        [Header("怪物陣列"), SerializeField]
        private GameObject[] goEnemys;
        [Header("生成格子第二排座標"), SerializeField]
        private Transform[] traSecondPlace;
        [Header("格子 彈珠"), SerializeField]
        private GameObject goMarble;

        [SerializeField]
        private List<Transform> listSecondPlace = new List<Transform>();

        /// <summary>
        /// 怪物與可以吃的彈珠存活總數
        /// </summary>
        public int totalCountEnemyLive;
        #endregion

        #region 事件
        private void Awake()
        {
            SpawnRandomEnemy();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 生成隨機敵人
        /// </summary>
        public void SpawnRandomEnemy()
        {
            int min = 2;
            int max = traSecondPlace.Length;

            int randomCount = Random.Range(min, max);
            // print("隨機怪物數量：" + randomCount);

            // 清單 = 陣列.轉為清單();
            listSecondPlace = traSecondPlace.ToList();

            // 隨機物件
            System.Random random = new System.Random();
            // 清單 = 清單 的 排序(每個清單內容 => 隨機排序) 轉為清單
            listSecondPlace = listSecondPlace.OrderBy(x => random.Next()).ToList();

            int sub = traSecondPlace.Length - randomCount;
            // print("要扣除的數量：" + sub);

            // 迴圈 刪除 要扣掉的數量
            for (int i = 0; i < sub; i++)
            {
                // 刪除第一個清單資料
                listSecondPlace.RemoveAt(0);
            }

            // 生成所有怪物與彈珠一顆
            for (int i = 0; i < listSecondPlace.Count; i++)
            {
                // 如果 i 等於 0 生成彈珠
                if (i == 0)
                {
                    Instantiate(
                    goMarble,
                    listSecondPlace[i].position,
                    Quaternion.identity);
                }
                else
                {
                    // 隨機怪物
                    int randomIndex = Random.Range(0, goEnemys.Length);
                    // 生成怪物
                    Instantiate(
                        goEnemys[randomIndex],
                        listSecondPlace[i].position,
                        Quaternion.identity);

                }

                totalCountEnemyLive++;
                // print("<color=#885511>怪物與彈珠數量：" + totalCountEnemyLive + "</color>");
            }
        }
        #endregion
    }
}

