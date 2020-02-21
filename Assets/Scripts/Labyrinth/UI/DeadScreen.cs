using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DeadScreen : MonoBehaviour
{
    [SerializeField] private GameObject deadImage = default;

    private void Awake()
    {
        deadImage.SetActive(false);
    }

    public void displayDeadScreen()
    {
        deadImage.SetActive(true);
        StartCoroutine(HideDeadImage());
    }

    private IEnumerator HideDeadImage()
    {
        yield return new WaitForSeconds(2f);
        deadImage.SetActive(false);
    }
}