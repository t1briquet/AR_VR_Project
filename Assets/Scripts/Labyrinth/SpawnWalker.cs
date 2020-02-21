using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalker : MonoBehaviour
{
    [SerializeField] private GameObject walkerPrefab = default;
    [SerializeField] private Transform player = default;
    
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