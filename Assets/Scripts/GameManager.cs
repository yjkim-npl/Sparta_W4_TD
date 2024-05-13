using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public string playerName { get; set; }
    private void Awake()
    {
        if(instance == null)
            instance = this;
        DontDestroyOnLoad(gameObject);
    }
}