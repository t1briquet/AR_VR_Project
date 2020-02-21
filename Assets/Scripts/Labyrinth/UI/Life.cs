using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    [SerializeField] private Player player = default;

    [SerializeField] private TMPro.TextMeshProUGUI lifeText = default;

    private void Update()
    {
        lifeText.text = player.Health.ToString();
    }
}