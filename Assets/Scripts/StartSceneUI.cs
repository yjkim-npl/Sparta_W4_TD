using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroUI : MonoBehaviour
{
    // Join ��ư ������ ��ǲ �ʵ忡 �Էµ� �̸� ��������
    [SerializeField] private TMP_InputField inf;

    [SerializeField] private Sprite[] characterImage;
    [SerializeField] private Image selectedCharacter;
    public void ChoiceChara(int num)
    {
        selectedCharacter.sprite = characterImage[num]; 
        DataManager.instance.SetCharaNum(num);
    }

    public void JoinBtn()
    {
        // Join ��ư ���� �� �ൿ �ۼ�
        if (inf.text.Length < 2 || inf.text.Length > 10)
            return;
        DataManager.instance.SetPlayerName(inf.text);
        // �Ʒ��� �� �ൿ�� ������ ����� �ʷ���
        SceneManager.LoadScene("MainScene");
        //SceneManager.LoadScene(1);
    }
}
