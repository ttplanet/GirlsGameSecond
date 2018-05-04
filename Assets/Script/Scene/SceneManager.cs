using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace GirlsGameSecond.Scene
{
    public class SceneManager : MonoBehaviour
    {
        public GameObject _cameraObjects;
        public Canvas _uiCanvas;
        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
            DontDestroyOnLoad(_cameraObjects);
            DontDestroyOnLoad(_uiCanvas);
        }
        public void SceneLoad(string sceneName)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }

    }
}

