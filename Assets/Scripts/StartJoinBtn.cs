using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartJoinBtn : PlayerChoice
{
    // Start is called before the first frame update
    [SerializeField] private InputField inf;
//    [SerializeField] private GameObject TestChara;
    string name = "";

    public void StartGame()
    {
        do
        {
            name = inf.text;
        }while ((inf.text.Length < 2 || inf.text.Length > 10) && GameManager.instance.playerChara == 0) ;
        GameManager.instance.playerName = name;
//        TestChara = GameObject.Find("Player1");
//        TestChara = Instantiate<GameObject>(GameManager.instance.player1Chara);
        SceneManager.LoadScene("MainScene");
        Resources.Load<GameObject>("Player1");
//            Instantiate();
    }

    private void Update()
    {
    }

}
