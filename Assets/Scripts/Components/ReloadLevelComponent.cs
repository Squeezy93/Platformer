using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Components
{
    public class ReloadLevelComponent : MonoBehaviour
    {
        public void ReloadLevel()
        {
            var currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}