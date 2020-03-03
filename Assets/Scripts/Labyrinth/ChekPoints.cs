using UnityEngine;

namespace Labyrinth
{
    public class ChekPoints : MonoBehaviour
    {
        [SerializeField] private Player player;

        private Transform _cpTransform;

        private void Awake()
        {
            _cpTransform = transform;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && player.Health > 0)
                player.lastCheckpoint = _cpTransform.position + Vector3.up * 2;
        }
    }
}