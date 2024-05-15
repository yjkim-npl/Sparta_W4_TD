using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TMP_Text name;
//    [SerializeField] private GameObject playerChara;
    // Start is called before the first frame update
    void Start()
    {
        name = GetComponentInChildren<TMP_Text>();
        name.text = DataManager.instance.GetPlayerName();
//        playerChara = GameManager.Instance.GetPlayerChara(DataManager.instance.GetCharaNum());
    }

    public void SetName(string in_name)
    {
        name.text = in_name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
