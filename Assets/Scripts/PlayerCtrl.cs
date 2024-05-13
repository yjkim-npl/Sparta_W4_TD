using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerCtrl : MainCtrl
{
    [SerializeField] private Text playerName;
    private Camera cam;
    protected override void Awake()
    {
        cam = Camera.main;
        playerName.text = GameManager.instance.playerName;
    }

    public void OnMove(InputValue val)
    {
        Vector2 dir = val.Get<Vector2>().normalized;
        CallMoveEvent(dir);
    }
    public void OnLook(InputValue val)
    {
        Vector2 dir = val.Get<Vector2>();
        Vector2 worldPos = cam.ScreenToWorldPoint(dir);
        dir = (worldPos - (Vector2)transform.position).normalized;
        CallLookEvent(dir);
    }
}
