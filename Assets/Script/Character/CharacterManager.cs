using GirlsGameSecond.Constant;
using GirlsGameSecond.Resource;
using Live2D.Cubism.Core;
using UnityEngine;

namespace GirlsGameSecond.Character
{
    public class CharacterManager : MonoBehaviour
    {
        public static CharacterManager Instance { get; private set; }
        private CubismModel _currentCubismModel;

        private void Start()
        {
            Instance = this;
            CreateCharacter(ResourcePathcConstant.CHARA_MEGAIRA);
        }

        /// <summary>
        /// 表示キャラクターの変更
        /// </summary>
        /// <param name="path">変更したいキャラクターのパス</param>
        public void ChangeCharacter(string path)
        {
            if (_currentCubismModel.gameObject != null)
            {
                DeleteCharacter();
                CreateCharacter(path);
            }
        }

        /// <summary>
        /// キャラクター作成
        /// </summary>
        /// <param name="path">作成したいキャラクターのパス</param>
        private void CreateCharacter(string path)
        {
            _currentCubismModel = CreateResource.Instance.CreateGameObject<CubismModel>(path, this.gameObject.transform);
        }

        /// <summary>
        /// キャラクター削除
        /// </summary>
        private void DeleteCharacter()
        {
            Destroy(_currentCubismModel.gameObject);
        }

        /// <summary>
        /// キャラクターアニメーション再生
        /// </summary>
        public void PlayAnimation()
        {
            //Idel
            //Dynamic
        }
    }
}