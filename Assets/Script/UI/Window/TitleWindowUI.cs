using GirlsGameSecond.Constant;
using GirlsGameSecond.Scene;
using UniRx;
using UnityEngine.UI;

namespace GirlsGameSecond.UI.Window
{
    public class TitleWindowUI : WindowBase
    {
        public Button _startButton;
        public Button _loadButton;
        public Button _otherButton;

        public override void Init(UIInfo uiInfo)
        {
            RegisterButton();
        }

        public override void Open(UIInfo uiInfo)
        {
        }

        public override void Back(UIInfo uiInfo)
        {
        }

        public override void Close(UIInfo uiInfo)
        {
        }
        /// <summary>
        /// ボタンの登録
        /// </summary>
        private void RegisterButton()
        {
            _startButton.OnClickAsObservable().Subscribe(_ => StartButtonProcess()).AddTo(this.gameObject);
            _loadButton.OnClickAsObservable().Subscribe(_ => LoadButtonProcess()).AddTo(this.gameObject);
            _otherButton.OnClickAsObservable().Subscribe(_ => OtherButtonProcess()).AddTo(this.gameObject);
        }

        /// <summary>
        /// スタートボタンの挙動
        /// </summary>
        private void StartButtonProcess()
        {
            //ウィンドウをタイトルからメインに変更
            UIManager.Instance.ChangeWindow<MainWindowUI>(ResourcePathcConstant.WINDOW_MAIN_PATH);

            SceneManager.GetInstance.SceneLoad(ScenePathConstant.SCENE_MAIN);
        }

        /// <summary>
        /// ロードボタンの挙動
        /// </summary>
        private void LoadButtonProcess()
        {
        }

        /// <summary>
        /// その他ボタンの挙動
        /// </summary>
        private void OtherButtonProcess()
        {
        }
    }
}