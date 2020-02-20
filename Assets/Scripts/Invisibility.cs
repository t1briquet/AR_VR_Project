using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisibility : MonoBehaviour
{
    [SerializeField] private Player player = default;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            player.invisible = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            player.invisible = false;
    }
}