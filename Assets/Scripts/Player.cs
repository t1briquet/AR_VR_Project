using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [NonSerialized] public GameObject player = default;

    [NonSerialized] public Transform playerTransform = default;
    [NonSerialized] public bool invisible = false;
    public int Health { get; private set; }
    public string lastTouched { get; private set; }
    public Vector3 lastCheckpoint;

    private void Awake()
    {
        player = gameObject;
        playerTransform = transform;
        Health = 100;
        lastTouched = "";
        lastCheckpoint = playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Debug.Log("T'es mort");
        }
    }

    public void HealPlayer(int value)
    {
        Health += value;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }

    public void OneShot()
    {
        Health = 0;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        lastTouched = hit.gameObject.name;
    }
}