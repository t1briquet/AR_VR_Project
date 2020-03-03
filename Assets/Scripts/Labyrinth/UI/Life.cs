using UnityEngine;

namespace Labyrinth.UI
{
    public class Life : MonoBehaviour
    {
        [SerializeField] private Player player;

        [SerializeField] private TMPro.TextMeshProUGUI lifeText;

        private void Update()
        {
            lifeText.text = player.Health.ToString();
        }
    }
}