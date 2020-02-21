using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

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
            player.lastCheckpoint = _cpTransform.position;
    }
}