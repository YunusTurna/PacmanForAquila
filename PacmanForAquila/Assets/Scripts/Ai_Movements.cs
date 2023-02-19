using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai_Movements : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _mvoementSpeed = 3.0f;
    Vector2[] _directions = {Vector2.up, Vector2.right, Vector2.down, Vector2.left};
    private int _directionIndex = 1;
    [SerializeField] Vector2 _currentDirection;
    [SerializeField] float _rayDistance;
    [SerializeField] LayerMask _rayLayer;
    public static Animator _anim;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }
    private void Start()
    {
        _currentDirection = _directions[_directionIndex];
    }

    private void Update()
    {
        RaycastHit2D hit2D = Physics2D.Raycast(transform.position, _currentDirection,_rayDistance, _rayLayer);
        Vector3 endpoint = _currentDirection * _rayDistance;
        Debug.DrawLine(transform.position, transform.position + endpoint, Color.green);

        if (hit2D.collider != null)
        {
            if (hit2D.collider.gameObject.CompareTag("Walls") || hit2D.collider.gameObject.CompareTag("Enemy"))
            {
               ChangeDirection();
            }
            if (hit2D.collider.gameObject.CompareTag("Pacman"))
            {
                print("hit pacman");
            }
        }
        Tag();
    }
    private void ChangeDirection()
    {
        _directionIndex += Random.Range(0, 2) * 2 -1;

        int _clampIndex = _directionIndex % _directions.Length;

        if (_clampIndex < 0)
        {
            _clampIndex = _directions.Length + _clampIndex;
        }
        _rb.velocity = Vector2.zero;
        _currentDirection = _directions[_clampIndex];
    }
    private void FixedUpdate()
    {
        _rb.AddForce(_currentDirection * _mvoementSpeed);
    }
    private void Tag()
    {
        if (PowerPellets.isAnim == true)
        {
            gameObject.tag = "EatableEnemy";
        }
    }
}
