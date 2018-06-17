using UniRx;
using UnityEngine;

namespace GirlsGameSecond.Inputs
{
    public class InputManager : MonoBehaviour
    {
        // Use this for initialization
        private void Start()
        {
#if UNITY_EDITOR
            Debug.Log("Unity Editor");
            this.ObserveEveryValueChanged(x => Input.GetAxisRaw("Mouse")).Where(x => x == 1).Subscribe(_ =>
            {
                Debug.Log("AAAA");
            }).AddTo(this.gameObject);

#elif UNITY_ANDROID
    Debug.Log("Unity Android");
#else
    Debug.Log("Any other platform");
#endif
        }
    }
}