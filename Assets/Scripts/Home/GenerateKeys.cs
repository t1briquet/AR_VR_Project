using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditorInternal;
using UnityEngine;
using Random = UnityEngine.Random;

public class GenerateKeys : MonoBehaviour
{
    [SerializeField] private GameObject key = default;

    private GameObject keysGO;
    private Transform keysTransform;

    private void Awake()
    {
        keysGO = gameObject;
        keysTransform = transform;
    }

    private void Start()
    {
        StartCoroutine(SpawnKeys());
    }

    private IEnumerator SpawnKeys()
    {
        yield return new WaitForSeconds(0.01f);

        if (keysTransform.childCount == 0)
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(key, GetRandomKeyPoition(), Quaternion.identity, keysTransform);
            }
        }
    }

    private Vector3 GetRandomKeyPoition()
    {
        float x = Random.Range(transform.position.x - 95f, transform.position.x + 95f);
        float z = Random.Range(transform.position.x - 45f, transform.position.y + 45f);
        return new Vector3(x, transform.position.y, z);
    }
}