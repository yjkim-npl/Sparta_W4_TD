using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // ���� ���࿡ �ʿ��� �����͵��� ����
    // �� ��ȯ�� �ı����� ������
    // ������ ���̼� -> �̱���

    public static DataManager instance;

    // �� �̵��� �Ѱ�����ϴ� ����
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
