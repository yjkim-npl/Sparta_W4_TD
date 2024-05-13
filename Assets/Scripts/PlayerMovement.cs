using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerCtrl ctrl;
    private Rigidbody2D rb;
    private Vector2 moveDir = Vector2.zero;

    private void Awake()
    {
        ctrl = GetComponent<PlayerCtrl>();
        rb = GetComponent<Rigidbody2D>();
        ctrl.OnMoveEvent += Move;
    }
    private void Start()
    {
    }

    private void Move(Vector2 dir)
    {
        moveDir = dir;
    }
    private void FixedUpdate()
    {
        ApplyMovement(moveDir);
    }

    private void ApplyMovement(Vector2 dir)
    {
        rb.velocity = 5.0f * dir;
    }
}
