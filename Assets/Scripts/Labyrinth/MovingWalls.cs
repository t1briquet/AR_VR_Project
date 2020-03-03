using UnityEngine;

namespace Labyrinth
{
    public class MovingWalls : MonoBehaviour
    {
        [SerializeField] private Player player;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
                player.OneShot();
        }
    }
}