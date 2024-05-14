using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] public GameObject player1Chara;
    [SerializeField] public GameObject player2Chara;
    public string playerName { get; set; }
    public int playerChara { get; set; }
    private void Awake()
    {
        playerName = "";
        if(instance == null)
            instance = this;
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
    }
}