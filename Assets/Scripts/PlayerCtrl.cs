using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerCtrl : MainCtrl
{
    [SerializeField] private Text playerName;
    public static GameObject player;

    private Camera cam;
    protected override void Awake()
    {
//        if(player == null)
//        {
//            if (GameManager.instance.playerChara == 1)
//            {
//                player = Resources.Load<GameObject>("Player1");
//            }
//            if (GameManager.instance.playerChara == 2)
//                player = Instantiate(GameManager.instance.player2Chara);
//        }
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
