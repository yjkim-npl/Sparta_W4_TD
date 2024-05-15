using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainSceneUI : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private TMP_InputField playerName;
    [SerializeField] private GameObject playerNameUI;
    [SerializeField] private GameObject charaChoiceUI;
    [SerializeField] private GameObject confirmBtn;

    void Start()
    {
        player = GameManager.Instance.GetPlayer();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePlayerBtn()
    {
        charaChoiceUI.SetActive(true);
        confirmBtn.SetActive(true);
    }
    public void ChangePlayerConfirmBtn()
    {
        DestroyObject(GameObject.FindGameObjectWithTag("Player"));
        player = Instantiate(GameManager.Instance.charaPerfabs[DataManager.instance.GetCharaNum()]);
        Camera.main.GetComponent<CameraFollow>().SetPlayer(player);
        charaChoiceUI.SetActive(false);
        confirmBtn.SetActive(false);
    }
    public void ChangePlayerMale()
    {
        DataManager.instance.SetCharaNum(0);
    }
    public void ChangePlayerFemale()
    {
        DataManager.instance.SetCharaNum(1);
    }
    public void ChangePlayerNameBtn()
    {
        playerNameUI.SetActive(true);
        confirmBtn.SetActive(true);
    }
    public void ChangePlayerNameConfirmBtn()
    {
        DataManager.instance.SetPlayerName(playerName.text);
        player.GetComponentInChildren<TMP_Text>().text = playerName.text;
        playerNameUI.SetActive(false);
        confirmBtn.SetActive(false);
    }

}
