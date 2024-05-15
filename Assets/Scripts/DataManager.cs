using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // 게임 진행에 필요한 데이터들을 관리
    // 씬 전환시 파괴되지 않을것
    // 접근의 용이성 -> 싱글톤

    public static DataManager instance;

    // 씬 이동시 넘겨줘야하는 정보
    private string userName;
    private int charaNum;
    private void Awake()
    {
        if ((instance == null))
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SetCharaNum(int num) { charaNum = num; }
    public int GetCharaNum() {  return charaNum; }
    public void SetPlayerName(string name) { userName = name; }
    public string GetPlayerName() { return userName; }
}
