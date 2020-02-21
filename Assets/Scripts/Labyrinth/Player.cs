using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    [SerializeField] private DeadScreen deadScreen = default;

    [NonSerialized] public GameObject player = default;

    [NonSerialized] public Transform playerTransform = default;
    [NonSerialized] public bool invisible = false;
    public int Health { get; private set; }
    public string lastTouched { get; private set; }
    public Vector3 lastCheckpoint;

    private CharacterController _playerController;

    private void Awake()
    {
        player = gameObject;
        _playerController = GetComponent<CharacterController>();
        playerTransform = transform;
        Health = 100;
        lastTouched = "";
        lastCheckpoint = playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health > 0) return;
        deadScreen.displayDeadScreen();
        Respawn();
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

    private void Respawn()
    {
        _playerController.enabled = false;
        playerTransform.position = lastCheckpoint;
        Health = 100;
        _playerController.enabled = true;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        lastTouched = hit.gameObject.name;
    }
}