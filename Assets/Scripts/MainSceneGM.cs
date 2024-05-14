using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneGM : MonoBehaviour
{
    public static MainSceneGM instance;
    // Start is called before the first frame update
    public GameObject playerPrefabs1;
    public GameObject playerPrefabs2;

    public static GameObject player;
    void Start()
    {
        if(instance == null)
            instance = this;
        if(GameManager.instance.playerChara == 1)
            player = Instantiate(playerPrefabs1);
        if(GameManager.instance.playerChara == 2)
            player = Instantiate(playerPrefabs2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
