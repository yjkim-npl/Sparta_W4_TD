using UnityEngine;

public class PlayerAnimCtrl : AnimCtrl
{
    private static readonly int isWalking = Animator.StringToHash("isWalk");

    private readonly float magThres = 0.1f;

    protected override void Awake()
    {
        base.Awake();
        ctrl.OnMoveEvent += AnimMove;
    }
    private void AnimMove(Vector2 v2)
    {
        anim.SetBool(isWalking, v2.magnitude > magThres);
    }
}
