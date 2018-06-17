using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GirlsGameSecond.UI.Window {
    public abstract class WindowBase : MonoBehaviour
    {

        public abstract void Init(UIInfo uiInfo);
        public abstract void Open(UIInfo uiInfo);
        public abstract void Close(UIInfo uiInfo);
        public abstract void Back(UIInfo uiInfo);

    }
}


