using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WinMenu
{
    public class WinMenu : MonoBehaviour
    {
        private void Awake()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        public void GoBackToMainMenu()
        {
            SceneManager.LoadScene(0);
        }
    }
}