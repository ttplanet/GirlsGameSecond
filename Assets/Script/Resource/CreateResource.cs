using System.Collections;
using System.Collections.Generic;
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
        public static CreateResource GetInstance
        {
            get
            {
                return _createResource;
            }
            
        }
        /// <summary>
        /// UICanvasに生成
        /// </summary>
        public GameObject CreateWindowUI(string windowPath,Transform parent)
        {
            GameObject prefab = Resources.Load<GameObject>(windowPath);
            GameObject instanceObject 
            = (GameObject)MonoBehaviour.Instantiate(prefab,prefab.transform.position,prefab.transform.rotation,parent);
            instanceObject.name = prefab.name;
            return instanceObject;
        }

    }
}

