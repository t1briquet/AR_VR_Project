using UnityEngine;
using UnityEngine.SceneManagement;

namespace Labyrinth
{
    public class Exit : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
                SceneManager.LoadScene(2);
        }
    }
}