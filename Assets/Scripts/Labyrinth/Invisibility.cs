using UnityEngine;

namespace Labyrinth
{
    public class Invisibility : MonoBehaviour
    {
        [SerializeField] private Player player;


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
                player.invisible = true;
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
                player.invisible = false;
        }
    }
}