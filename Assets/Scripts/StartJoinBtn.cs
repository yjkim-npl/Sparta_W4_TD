using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartJoinBtn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private InputField inf;
    string name = "";

    public void StartGame()
    {
        do
        {
            name = inf.text;
        }while (inf.text.Length < 2 || inf.text.Length > 10) ;
        SceneManager.LoadScene("MainScene");
        GameManager.instance.playerName = name;
    }

}
