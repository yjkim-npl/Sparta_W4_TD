using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private Camera cam;
    public GameObject[] charaPerfabs;
    private GameObject player;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            return;
        //        Resources.Load("PlayerM");
        player = Instantiate(charaPerfabs[DataManager.instance.GetCharaNum()]);
        cam.GetComponent<CameraFollow>().SetPlayer(player);
    }
    public GameObject GetPlayerChara(int num)
    {
        return charaPerfabs[num];
    }
    public GameObject GetPlayer() { return player; }
}
