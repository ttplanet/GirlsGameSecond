using UnityEngine;
using GirlsGameSecond.Resource;
using GirlsGameSecond.Constant;
namespace GirlsGameSecond.UI
{
    public class UIManager : MonoBehaviour
    {
        public Transform _uiBase;

        
        private void Start()
        {
            //タイトルシーンの生成
            CreateResource.GetInstance.CreateWindowUI(ResourcePathcConstant.WINDOW_TITLE_PATH,_uiBase);

        }
    }
}