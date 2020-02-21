using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerController : MonoBehaviour
{
    [SerializeField] private float walkerSpeed = default;
    [SerializeField] private int damage = default;

    private Player _player;
    private Transform _playerTransform;
    private Transform _walkerTransform;
    private Animator _animator;
    private static readonly int IsWalking = Animator.StringToHash("isWalking");

    private Vector3 _initialPosition;
    private float _inactiveTimer = 0;

    private void Awake()
    {
        _player = GameObject.FindWithTag("Player").GetComponent<Player>();
        _playerTransform = _player.playerTransform;
        _walkerTransform = transform;
        _animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _initialPosition = _walkerTransform.position;
        _walkerTransform.LookAt(_playerTransform.position);
    }

    // Update is called once per frame
    void Update()
    {
        _walkerTransform.LookAt(_playerTransform.position);
        if (_inactiveTimer >= 180f)
            Destroy(gameObject);
        if (_player.invisible == false)
        {
            if (Vector3.Distance(_playerTransform.position, _walkerTransform.position) < 2)
            {
                _inactiveTimer = 0;
                _animator.SetBool(IsWalking, true);
                _walkerTransform.position =
                    Vector3.MoveTowards(_walkerTransform.position, _playerTransform.position,
                        walkerSpeed * Time.deltaTime);
            }
            else
            {
                _animator.SetBool(IsWalking, false);
                _inactiveTimer += Time.deltaTime;
            }
        }
        else
        {
            _inactiveTimer = 0;
            _walkerTransform.position =
                Vector3.MoveTowards(_walkerTransform.position, _initialPosition, walkerSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(("Player")))
        {
            _player.TakeDamage(damage);
        }
    }
}