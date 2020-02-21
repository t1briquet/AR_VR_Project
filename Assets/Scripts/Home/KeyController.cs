using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = default;
    private Transform _keyTransform = default;
    private float _rotationAngle = default;


    private void Awake()
    {
        _keyTransform = transform;
    }

    private void Update()
    {
        _rotationAngle = (_rotationAngle + rotationSpeed) % 360;
        _keyTransform.rotation = Quaternion.Euler(0f, _rotationAngle, 0f);
    }
}