using UnityEngine;

namespace Labyrinth.UI
{
    public class TouchedObject : MonoBehaviour
    {
        [SerializeField] private Player player;

        [SerializeField] private TMPro.TextMeshProUGUI lifeText;

        private void Update()
        {
            lifeText.text = player.lastTouched;
        }
    }
}