using System;
using TMPro;
using UnityEngine;

namespace Home
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private TMPro.TextMeshProUGUI distance;
        [SerializeField] private TMPro.TextMeshProUGUI distanceValue;
        [SerializeField] private Camera camera;

        private Transform _playerTransform;

        private void Awake()
        {
            _playerTransform = transform;
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.R))
            {
                distance.enabled = true;
                distanceValue.enabled = true;
                Ray ray = camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                Physics.Raycast(ray, out hit);
                distanceValue.text = hit.distance.ToString();
            }
            else
            {
                distance.enabled = false;
                distanceValue.enabled = false;
            }
        }
    }
}