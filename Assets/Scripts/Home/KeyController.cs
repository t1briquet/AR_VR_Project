using UnityEngine;

namespace Home
{
    public class KeyController : MonoBehaviour
    {
        [SerializeField] private float rotationSpeed;

        private GameObject _keyGo;
        private Transform _keyTransform;
        private GenerateKeys _keyGenerator;
        private float _rotationAngle;


        private void Awake()
        {
            _keyGo = gameObject;
            _keyTransform = transform;
            _keyGenerator = _keyTransform.parent.GetComponent<GenerateKeys>();
        }

        private void Update()
        {
            _rotationAngle = (_rotationAngle + rotationSpeed) % 360;
            _keyTransform.rotation = Quaternion.Euler(0f, _rotationAngle, 0f);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (_keyGo.CompareTag("Golden_Key"))
                _keyGenerator.HitGoldenKey();
            else
                _keyGenerator.HitNormalKey();
        }
    }
}