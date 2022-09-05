using UnityEngine;
using UnityEngine.Events;

namespace KID
{
    /// <summary>
    /// 回合系統：玩家或敵人回合管理
    /// </summary>
    public class SystemTurn : MonoBehaviour
    {
        #region 資料
        /// <summary>
        /// 敵人回合
        /// </summary>
        public UnityEvent onTurnEnemy;

        private SystemControl systemControl;
        private SystemSpawn systemSpawn;
        private RecycleArea recycleArea;

        /// <summary>
        /// 彈珠總數
        /// </summary>
        private int totalCountMarble;
        /// <summary>
        /// 怪物與可以吃的彈珠存活總數
        /// </summary>
        private int totalCountEnemyLive;
        /// <summary>
        /// 回收彈珠數量
        /// </summary>
        private int totalRecycleMarble;
        private bool canSpawn = true;
        #endregion

        private int countMarbleEat;

        private void Awake()
        {
            systemControl = GameObject.Find("哥布林").GetComponent<SystemControl>();
            systemSpawn = GameObject.Find("生成怪物系統").GetComponent<SystemSpawn>();
            recycleArea = GameObject.Find("回收區域").GetComponent<RecycleArea>();

            recycleArea.onRecycle.AddListener(RecycleMarble);
        }

        /// <summary>
        /// 回收彈珠
        /// </summary>
        private void RecycleMarble()
        {
            totalCountMarble = systemControl.canShootMarbleTotal;

            totalRecycleMarble++;
            // print("<color=yellow>彈珠回收數量：" + totalRecycleMarble + "</color>");

            if (totalRecycleMarble == totalCountMarble)
            {
                // print("回收完畢，換敵人回合");
                onTurnEnemy.Invoke();
            }
        }

        /// <summary>
        /// 移動結束後生成敵人與彈珠
        /// </summary>
        public void MoveEndSpawnEnemy()
        {
            if (!canSpawn) return;

            canSpawn = false;
            systemSpawn.SpawnRandomEnemy();
            Invoke("PlayerTurn", 1);
        }

        /// <summary>
        /// 玩家回合
        /// </summary>
        private void PlayerTurn()
        {
            systemControl.canShootMarble = true;
            canSpawn = true;
            totalRecycleMarble = 0;

            #region 彈珠數量處理
            systemControl.canShootMarbleTotal += countMarbleEat;
            countMarbleEat = 0;
            #endregion
        }

        /// <summary>
        /// 吃到彈珠數量遞增
        /// </summary>
        public void MarbleEat()
        {
            countMarbleEat++;
        }
    }
}
