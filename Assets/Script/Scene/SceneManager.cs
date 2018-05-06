using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace GirlsGameSecond.Scene
{
    public class SceneManager
    {
        private static SceneManager _sceneManager=new SceneManager();
        public static SceneManager GetInstance
        {
            get
            {
                return _sceneManager;
            }
        }



        public void SceneLoad(string sceneName)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }

    }
}

