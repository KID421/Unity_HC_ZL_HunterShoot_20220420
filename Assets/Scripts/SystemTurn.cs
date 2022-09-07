using UnityEngine;
using UnityEngine.Events;
using TMPro;

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

        [SerializeField, Header("沒有移動物件並且延遲生成的時間"), Range(0, 3)]
        private float noMoveObjectAndDelaySpawn = 1;
        [SerializeField, Header("當前層數最大值"), Range(1, 100)]
        private int countFloorMax = 50;

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
        private int countMarbleEat;
        /// <summary>
        /// 層數數字
        /// </summary>
        private TextMeshProUGUI textFloorCount;
        private int countFloor = 1;
        private bool isFloorCountMax;
        #endregion

        private SystemFinal systemFinal;

        private void Awake()
        {
            systemControl = GameObject.Find("哥布林").GetComponent<SystemControl>();
            systemSpawn = GameObject.Find("生成怪物系統").GetComponent<SystemSpawn>();
            recycleArea = GameObject.Find("回收區域").GetComponent<RecycleArea>();
            textFloorCount = GameObject.Find("層數數字").GetComponent<TextMeshProUGUI>();

            recycleArea.onRecycle.AddListener(RecycleMarble);

            systemFinal = FindObjectOfType<SystemFinal>();
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

                // 如果沒有敵人就移動結束並生成敵人與彈珠
                if (FindObjectsOfType<SystemMove>().Length == 0)
                {
                    Invoke("MoveEndSpawnEnemy", noMoveObjectAndDelaySpawn);
                }
            }
        }

        /// <summary>
        /// 移動結束後生成敵人與彈珠
        /// </summary>
        public void MoveEndSpawnEnemy()
        {
            if (!canSpawn) return;
            if (!isFloorCountMax)
            {
                canSpawn = false;
                systemSpawn.SpawnRandomEnemy();
            }

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

            if (countFloor < countFloorMax)
            {
                countFloor++;
                textFloorCount.text = countFloor.ToString();
            }
            if (countFloor == countFloorMax) isFloorCountMax = true;

            if (isFloorCountMax)
            {
                if (FindObjectsOfType<SystemMove>().Length == 0)
                {
                    systemFinal.ShowFinalAndUpdateSubTitle("恭喜挑戰關卡成功！");
                }
            }
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
