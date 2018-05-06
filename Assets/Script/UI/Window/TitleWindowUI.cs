using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GirlsGameSecond.Scene;
using GirlsGameSecond.Constant;
using UniRx;
namespace GirlsGameSecond.UI.Window
{
    public class TitleWindowUI : MonoBehaviour
    {
        public Button _startButton;
        public Button _loadButton;
        public Button _otherButton;


        // Use this for initialization
        void Start()
        {
            RegisterButton();
        }
        private void RegisterButton()
        {
            _startButton.OnClickAsObservable().Subscribe(_ => StartButtonProcess()).AddTo(_startButton);
            _loadButton.OnClickAsObservable().Subscribe(_=> LoadButtonProcess()).AddTo(_loadButton);
            _otherButton.OnClickAsObservable().Subscribe(_=>OtherButtonProcess()).AddTo(_otherButton);
        }
        /// <summary>
        /// スタートボタンの挙動
        /// </summary>
        private void StartButtonProcess()
        {
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

