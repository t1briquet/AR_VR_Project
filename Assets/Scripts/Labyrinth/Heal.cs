using UnityEngine;

namespace Labyrinth
{
    public class Heal : MonoBehaviour
    {
        [SerializeField] private Player player;
        [SerializeField] private int healValue = 2;


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
                player.HealPlayer(healValue);
        }
    }
}