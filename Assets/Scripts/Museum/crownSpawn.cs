using UnityEngine;
using Random = UnityEngine.Random;

namespace Museum
{
    public class crownSpawn : MonoBehaviour
    {
        [SerializeField] private GameObject crown;
        private Vector3 _controllerPosition;
        private Transform _crownTransform;

        private bool _crownSpawned = true;

        private float _timer;

        private void Awake()
        {
            _crownTransform = transform;
            _controllerPosition = _crownTransform.position;
        }

        private void Start()
        {
            SpawnCrown();
        }

        private void Update()
        {
            if (_crownSpawned)
            {
                if (_timer >= 15f)
                {
                    foreach (Transform child in _crownTransform)
                    {
                        Destroy(child.gameObject);
                    }

                    _timer = 0f;
                    _crownSpawned = false;
                }
            }
            else
            {
                SpawnCrown();
                _timer = 0;
                _crownSpawned = true;
            }

            _timer += Time.deltaTime;
        }

        private void SpawnCrown()
        {
            
                // Spawn 1 crown
                Instantiate(crown, GetRandomCrownPosition(), Quaternion.identity, _crownTransform);
        }

        private Vector3 GetRandomCrownPosition()
        {
            float x = Random.Range(_controllerPosition.x - 95f, _controllerPosition.x + 95f);
            float z = Random.Range(_controllerPosition.y - 0f, _controllerPosition.y + 90f);
            return new Vector3(x, _controllerPosition.y, z);
        }
       
    }
}