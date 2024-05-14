using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChoice : MonoBehaviour
{
    public void ChooseChara1()
    {
        GameManager.instance.playerChara = 1;
    }
    public void ChooseChara2()
    {
        GameManager.instance.playerChara = 2;
    }
}
