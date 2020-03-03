using UnityEngine;

namespace MainMenu
{
    public class ButtonStyleController : MonoBehaviour
    {
        public void ColorToPurple(TMPro.TextMeshProUGUI text)
        {
            text.color = new Color(201, 0, 255);
        }

        public void ColorToWhite(TMPro.TextMeshProUGUI text)
        {
            text.color = Color.white;
        }
    }
}