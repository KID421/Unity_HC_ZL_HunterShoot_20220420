using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 遊戲結束系統：勝利與失敗
    /// </summary>
    public class SystemFinal : MonoBehaviour
    {
        #region 資料
        /// <summary>
        /// 遊戲結束畫面底圖
        /// </summary>
        private CanvasGroup groupFinal;
        /// <summary>
        /// 遊戲結束小標題
        /// </summary>
        private TextMeshProUGUI textSubTitle;
        /// <summary>
        /// 重新遊戲
        /// </summary>
        private Button btnReplay;
        /// <summary>
        /// 離開遊戲
        /// </summary>
        private Button btnQuit;
        #endregion

        private void Awake()
        {
            groupFinal = GameObject.Find("遊戲結束畫面底圖").GetComponent<CanvasGroup>();
            textSubTitle = GameObject.Find("遊戲結束小標題").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("重新遊戲").GetComponent<Button>();
            btnQuit = GameObject.Find("離開遊戲").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);                                  // 按下重新遊戲按鈕後 執行 Replay 方法
            btnQuit.onClick.AddListener(Quit);                                      // 按下利開遊戲按鈕後 執行 Quit 方法
        }

        /// <summary>
        /// 顯示結束畫面並更新小標題
        /// </summary>
        /// <param name="subTitle">小標題文字</param>
        public void ShowFinalAndUpdateSubTitle(string subTitle)
        {
            textSubTitle.text = subTitle;
            StartCoroutine(ShowFinal());
        }

        /// <summary>
        /// 顯示介面
        /// </summary>
        private IEnumerator ShowFinal()
        {
            for (int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.03f);
            }

            groupFinal.interactable = true;     // 畫布群組.互動 = 啟動
            groupFinal.blocksRaycasts = true;   // 畫布群組.遮擋射線 = 啟動
        }

        /// <summary>
        /// 重新遊戲功能
        /// </summary>
        private void Replay()
        {
            string nameCurrent = SceneManager.GetActiveScene().name;    // 取得當前場景名稱
            SceneManager.LoadScene(nameCurrent);                        // 場景管理.載入場景(名稱)
        }

        /// <summary>
        /// 離開按鈕功能
        /// </summary>
        private void Quit()
        {
            Application.Quit();     // 應用程式.離開()； - 關閉遊戲，Unity 內無作用
        }
    }
}
