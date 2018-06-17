using GirlsGameSecond.Constant;
using GirlsGameSecond.Resource;
using GirlsGameSecond.UI.Parts;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;

namespace GirlsGameSecond.UI.Window
{
    public class MainWindowUI : WindowBase
    {
        #region Button

        public Button _menuButton;
        public Button _saveButton;
        public Button _loadButton;
        public Button _titleButton;

        #endregion Button

        public Text _storyText;//ストーリーを表示するテキスト
        public Animator _menuBoxAnimator;
        public Transform _contentsChoiceTransform;
        public Image _contentsChoiceImage;
        private bool _isMenuOpen;
        private const string ANIMATION_TRIGGER_MENUOPEN = "menu_open";
        private const string ANIMATION_TRIGGER_MENUCLOSE = "menu_close";

        public override void Init(UIInfo uiInfo)
        {
            _contentsChoiceImage.enabled = false;
            _isMenuOpen = false;
            //ストーリ読み込み(セーブしていなかったら最初から)
            TextAsset story = Resources.Load<TextAsset>(ResourcePathcConstant.STORY_SAMPLE);

             string[] sp = story.text.Split('@');

            
            #region RegisterButton
            _menuButton.OnClickAsObservable().Subscribe(_ => OpenMenuBox()).AddTo(this.gameObject);
            _saveButton.OnClickAsObservable().Subscribe(_ => SaveData()).AddTo(this.gameObject);
            _loadButton.OnClickAsObservable().Subscribe(_ => LoadData()).AddTo(this.gameObject);
            _titleButton.OnClickAsObservable().Subscribe(_ => ReturnTitle()).AddTo(this.gameObject);
            #endregion RegisterButton
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


        private void LoadStory()
        {

        }

        #region Menu

        /// <summary>
        /// メニューボックスが開いたり閉じたり
        /// </summary>
        private void OpenMenuBox()
        {
            if (_isMenuOpen)
            {
                _menuBoxAnimator.SetTrigger(ANIMATION_TRIGGER_MENUCLOSE);
                _isMenuOpen = false;
            }
            else
            {
                _menuBoxAnimator.SetTrigger(ANIMATION_TRIGGER_MENUOPEN);
                _isMenuOpen = true;
            }
        }

        /// <summary>
        /// 保存する
        /// </summary>
        private void SaveData()
        {
        }

        /// <summary>
        /// 読み込む
        /// </summary>
        private void LoadData()
        {
        }

        /// <summary>
        /// タイトルに戻る
        /// </summary>
        private void ReturnTitle()
        {
        }

        #endregion Menu

        #region Choice

        /// <summary>
        /// 選択肢を生成する
        /// </summary>
        public void CreateChoice()
        {
            _contentsChoiceImage.enabled = true;
            ChoiceButtonUI choiceButtonUI = CreateResource.Instance.CreateGameObject<ChoiceButtonUI>(ResourcePathcConstant.PARTS_BUTTON_CHOICE);
            choiceButtonUI.Init();
        }

        #endregion Choice
    }
}