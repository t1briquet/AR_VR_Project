using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class Play : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene(1);
        }
    }
}
