using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform _GroundCheckTransform;
    [SerializeField] private float _JumpSpeed = 10;
    [SerializeField] private float _PlayerSpeed = 10;
    [SerializeField] private int _PlayerNumber;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float ySpeed = _rb.velocity.y;
        if (Input.GetButton("Jump" + _PlayerNumber))
        {
            ySpeed = _JumpSpeed;
        }
        _rb.velocity = new Vector2(_PlayerSpeed * Input.GetAxis("Horizontal" + _PlayerNumber), ySpeed);
    }
}