using UnityEngine;

public class PlayerAnimCtrl : AnimCtrl
{
    private static readonly int isWalking = Animator.StringToHash("isWalk");
    private static readonly int Direction = Animator.StringToHash("Direction");
    private bool mouseLR = false; // error
    private bool LR = true;
    private bool UD = true;

    private readonly float magThres = 0.1f;

    protected override void Awake()
    {
        base.Awake();
        ctrl.OnMoveEvent += AnimMove;
    }
    private void AnimMove(Vector2 v2)
    {
        Debug.Log(v2.x + ", " + v2.y);
        anim.SetBool(isWalking, v2.magnitude > magThres);
        if(mouseLR)
        {
            float rotZ = Mathf.Atan2(v2.y, v2.x) * Mathf.Rad2Deg;
            int facing = Mathf.Abs(rotZ) > 90 ? 3 : 2;
            anim.SetInteger(Direction, facing);
        }
        else if(LR || UD)
        {
            float AbsX = Mathf.Abs(v2.x);
            float AbsY = Mathf.Abs(v2.y);
            if(!UD)
            {
                int facing = v2.x > 0 ? 3 : 2;
                anim.SetInteger(Direction, facing);
            }
            else
            {
                int facing;
                if (AbsX >= AbsY)
                {
                    facing = v2.x > 0 ? 3 : 2;
                }
                else if (AbsY > AbsX)
                {
                    facing = v2.y > 0 ? 0 : 1;
                }
                else
                    facing = -1;
                anim.SetInteger(Direction, facing);
            }
        }
    }
}
