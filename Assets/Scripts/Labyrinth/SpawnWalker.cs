using UnityEngine;

namespace Labyrinth
{
    public class SpawnWalker : MonoBehaviour
    {
        [SerializeField] private GameObject walkerPrefab;
        [SerializeField] private Transform player;
    
        private Transform _spawnerTransform;
    

        private void Awake()
        {
            _spawnerTransform = transform;
        }

        private void Update()
        {
            if (_spawnerTransform.childCount < 1)
            {
                if (Vector3.Distance(player.position, _spawnerTransform.position) < 4f)
                {
                    Instantiate(walkerPrefab, _spawnerTransform.position, Quaternion.identity, _spawnerTransform);
                }
            }
        }
    }
}