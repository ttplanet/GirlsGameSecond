using GirlsGameSecond.Constant;
using GirlsGameSecond.Resource;
using GirlsGameSecond.UI.Window;
using UnityEngine;

namespace GirlsGameSecond.UI
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager Instance { get; private set; }
        private static UIInfo UIInfo = new UIInfo();

        public GameObject CurrentWindow { get; private set; }
        public Transform _uiCanvas;

        private void Start()
        {
            
            Instance = this;

            CreateWindow<TitleWindowUI>(ResourcePathcConstant.WINDOW_TITLE_PATH);
        }

        #region Window
        /// <summary>
        /// 画面を変更
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        public void ChangeWindow<T>(string path) where T : WindowBase
        {
            if (Instance.CurrentWindow != null)
            {
                CloseWindow();
                CreateWindow<T>(path);
            }
        }

        /// <summary>
        /// ウィンドウを作成
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        private void CreateWindow<T>(string path) where T : WindowBase
        {
            T window = CreateResource.Instance.CreateGameObject<T>(path, _uiCanvas);
            window.Init(UIInfo);

            Instance.CurrentWindow = window.gameObject;
        }

        /// <summary>
        /// ウィンドウを閉じる
        /// </summary>
        private void CloseWindow()
        {
            Instance.CurrentWindow.GetComponent<WindowBase>().Close(UIInfo);
            Destroy(Instance.CurrentWindow);
        }
        #endregion Window

        #region Button

        #endregion Button
    }
}