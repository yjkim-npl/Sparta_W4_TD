using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCtrl : MonoBehaviour
{
    protected Animator anim;
    protected MainCtrl ctrl;

    protected virtual void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        ctrl = GetComponentInChildren<MainCtrl>();
    }
}
