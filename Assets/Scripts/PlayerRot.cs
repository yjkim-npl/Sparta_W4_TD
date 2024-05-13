using System;
using UnityEngine;

public class PlayerRot : MonoBehaviour
{
    [SerializeField] private SpriteRenderer playerRdr;

    private MainCtrl ctrl;
    private Vector2 facingDir = Vector2.zero;

    private void Awake()
    {
        ctrl = GetComponent<MainCtrl>();
        playerRdr = GetComponent<SpriteRenderer>();
        ctrl.OnLookEvent += Look;
    }

    private void Look(Vector2 dir)
    {
        facingDir = dir.normalized;
    }
    private void FixedUpdate()
    {
        ApplyRotation(facingDir);
    }

    private void ApplyRotation(Vector2 dir)
    {
        float rotZ = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
        playerRdr.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
