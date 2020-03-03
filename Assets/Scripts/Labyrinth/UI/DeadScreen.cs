using System.Collections;
using UnityEngine;

namespace Labyrinth.UI
{
    public class DeadScreen : MonoBehaviour
    {
        [SerializeField] private GameObject deadImage;

        private void Awake()
        {
            deadImage.SetActive(false);
        }

        public void DisplayDeadScreen()
        {
            deadImage.SetActive(true);
            StartCoroutine(HideDeadImage());
        }

        private IEnumerator HideDeadImage()
        {
            yield return new WaitForSeconds(2f);
            deadImage.SetActive(false);
        }
    }
}