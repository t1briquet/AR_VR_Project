using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [NonSerialized] public GameObject player = default;

    [NonSerialized] public Transform playerTransform = default;

    private int _health;
    public bool invisible = false;

    private void Awake()
    {
        player = gameObject;
        playerTransform = transform;
        _health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (_health <= 0)
        {
            Debug.Log("T'es mort");
        }
    }

    public void HealPlayer(int value)
    {
        _health += value;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
}