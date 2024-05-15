using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeUI : MonoBehaviour
{
    // Start is called before the first frame update
    private TMP_Text timeTxt;
    void Start()
    {
        timeTxt = GetComponent<TMP_Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var today = System.DateTime.Now;
        timeTxt.text = today.ToString("HH:mm:ss");
    }
}
