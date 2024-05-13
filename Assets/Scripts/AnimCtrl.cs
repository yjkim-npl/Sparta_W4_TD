using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCtrl : MonoBehaviour
{
    protected Animator anim;
    protected MainCtrl ctrl;

    protected virtual void Awake()
    {
        Debug.Log("PlayerAnim Awake");
        anim = GetComponent<Animator>();
        ctrl = GetComponent<MainCtrl>();
    }
}
