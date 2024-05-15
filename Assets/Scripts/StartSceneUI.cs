using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroUI : MonoBehaviour
{
    // Join 버튼 누르면 인풋 필드에 입력된 이름 가져오기
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
        // Join 버튼 누를 시 행동 작성
        if (inf.text.Length < 2 || inf.text.Length > 10)
            return;
        DataManager.instance.SetPlayerName(inf.text);
        // 아래와 두 행동은 동일한 결과를 초래함
        SceneManager.LoadScene("MainScene");
        //SceneManager.LoadScene(1);
    }
}
