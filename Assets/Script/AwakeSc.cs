using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GirlsGameSecond
{
    public class AwakeSc : MonoBehaviour
    {

        /// <summary>
        /// 最初のawake処理だけするやつ
        /// </summary>
        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);

        }
    }
}

