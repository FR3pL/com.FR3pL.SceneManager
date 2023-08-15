using UnityEngine;
using UnityEngine.SceneManagement;

namespace TwoDSceneManager
{
    /// <summary>
    /// 場景切換管理
    /// </summary>
    public class MyScenemanager : MonoBehaviour
    {
        [SerializeField, Range(0, 3), Header("音效時長")]
        private float soundDuration = 1;

        /// <summary>
        /// 場景切換
        /// </summary>
        /// <param name="sceneName"></param>
        private string delayChSce;
        public void DelayChange(string sceneName)
        {
            delayChSce = sceneName;
            Invoke("ChangeScene", soundDuration);
        }
        private void ChangeScene()
        {
            SceneManager.LoadScene(delayChSce);
        }
        
        public void DelayQuit()
        {
            Invoke("QuitG", soundDuration);
        }
        private void QuitG()
        {
            Application.Quit();
        }        
    }
}

