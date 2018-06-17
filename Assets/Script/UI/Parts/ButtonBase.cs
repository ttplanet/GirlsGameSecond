using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
namespace GirlsGameSecond.UI.Parts
{
    public abstract class ButtonBase : MonoBehaviour
    {
        public Button _button;
        public abstract void Init();

    }
}

