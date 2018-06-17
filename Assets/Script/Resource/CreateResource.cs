using UnityEngine;

namespace GirlsGameSecond.Resource
{
    /// <summary>
    /// リソースを
    /// </summary>
    public class CreateResource
    {
        private static CreateResource _createResource = new CreateResource();

        //プロパティ
        public static CreateResource Instance
        {
            get
            {
                return _createResource;
            }
        }

        /// <summary>
        /// スクリプト付きのゲームオブジェクトを生成
        /// </summary>
        public T CreateGameObject<T>(string resourcePath, Transform parent = null) where T : MonoBehaviour
        {
            GameObject prefab = Resources.Load<GameObject>(resourcePath);
            GameObject instanceObject = null;
            if (parent == null)
            {
                instanceObject = (GameObject)MonoBehaviour.Instantiate(prefab, prefab.transform.position, prefab.transform.rotation);
            }
            else
            {
                instanceObject = (GameObject)MonoBehaviour.Instantiate(prefab, parent.position, parent.rotation, parent);
            }
            instanceObject.name = prefab.name;

            T t = (T)(object)instanceObject.GetComponent<T>();
            return t;
        }
    }
}