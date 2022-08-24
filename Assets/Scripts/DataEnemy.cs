using UnityEngine;

namespace KID
{
    // ScriptableObject 腳本化物件：腳本內容變成物件資料存放在 Project 內
    // 必須搭配 CreateAssetMenu
    [CreateAssetMenu(menuName = "KID/Data Enemy", fileName = "Data Enemy")]
    public class DataEnemy : ScriptableObject
    {
        [Header("血量"), Range(0, 10000)]
        public float hp;
        [Header("傷害"), Range(0, 10000)]
        public float damage;
        [Header("掉落金幣預製物")]
        public GameObject goCoin;
        [Header("掉落金幣範圍")]
        public Vector2Int v2CoinRange;
    }
}
