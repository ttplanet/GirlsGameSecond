using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GirlsGameSecond
{
    public class AwakeSc : MonoBehaviour
    {
        public GameObject _cameraObjects;
        public Canvas _uiCanvas;
        /// <summary>
        /// 最初のawake処理だけするやつ
        /// </summary>
        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
            DontDestroyOnLoad(_cameraObjects);
            DontDestroyOnLoad(_uiCanvas);
        }
    }
}

