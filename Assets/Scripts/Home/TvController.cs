using System;
using UnityEngine;

namespace Home
{
    public class TvController : MonoBehaviour
    {
        [SerializeField] private Transform playerTransform;

        private Transform _tvTransform;
        private MeshRenderer _renderer;

        private void Awake()
        {
            _tvTransform = transform;
            _renderer = GetComponent<MeshRenderer>();
        }

        private void Update()
        {
            if (Vector3.Distance(_tvTransform.position, playerTransform.position) < 6)
                _renderer.enabled = true;
            else
                _renderer.enabled = false;
        }
    }
}