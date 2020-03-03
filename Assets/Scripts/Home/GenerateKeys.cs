using UnityEngine;
using Random = UnityEngine.Random;

namespace Home
{
    public class GenerateKeys : MonoBehaviour
    {
        [SerializeField] private GameObject key;
        [SerializeField] private GameObject goldenKey;
        [SerializeField] private TMPro.TextMeshProUGUI lifeText;
        [SerializeField] private GameObject walls;


        private Transform _keysTransform;
        private Vector3 _controllerPosition;

        private int _activeKeys = 5;
        private bool _keyspawned = true;
        private float _timer;
        private static readonly int LevelFinished = Animator.StringToHash("levelFinished");


        private void Awake()
        {
            _keysTransform = transform;
            _controllerPosition = _keysTransform.position;
        }

        private void Start()
        {
            SpawnKeys();
        }

        private void Update()
        {
            if (_keyspawned)
            {
                lifeText.text = _activeKeys.ToString();
                if (_timer >= 30f && _activeKeys != 0)
                {
                    foreach (Transform child in _keysTransform)
                    {
                        Destroy(child.gameObject);
                    }

                    _timer = 0f;
                    _keyspawned = false;
                }
            }
            else
            {
                lifeText.text = "5";
                if (_timer >= 60f)
                {
                    SpawnKeys();
                    _timer = 0;
                    _keyspawned = true;
                }
            }

            _timer += Time.deltaTime;
        }

        private void SpawnKeys()
        {
            for (int i = 0; i < _activeKeys; i++)
            {
                // Spawn 1 golden key and  normal keys
                Instantiate(i == 0 ? goldenKey : key, GetRandomKeyPoition(), Quaternion.identity, _keysTransform);
            }
        }

        private Vector3 GetRandomKeyPoition()
        {
            float x = Random.Range(_controllerPosition.x - 95f, _controllerPosition.x + 95f);
            float z = Random.Range(_controllerPosition.y - 0f, _controllerPosition.y + 90f);
            return new Vector3(x, _controllerPosition.y, z);
        }


        public void HitGoldenKey()
        {
            foreach (Transform child in _keysTransform)
            {
                Destroy(child.gameObject);
            }

            _activeKeys -= 1;
            _timer = 0f;

            if (_activeKeys > 0)
                SpawnKeys();
            else Destroy(walls);
        }

        public void HitNormalKey()
        {
            foreach (Transform child in _keysTransform)
            {
                Destroy(child.gameObject);
            }

            _timer = 0f;
            _activeKeys = 5;
            SpawnKeys();
        }
    }
}