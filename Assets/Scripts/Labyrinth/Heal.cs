using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private Player player = default;
    [SerializeField] private int healValue = 2;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            player.HealPlayer(healValue);
    }
}