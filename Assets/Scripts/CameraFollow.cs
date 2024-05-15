using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private GameObject player;
    private void Start()
    {
        Vector2 v2;
    }

    private void LateUpdate()
    {
        var pos = player.transform.position;
        pos.z = -10;
        transform.position = pos;
    }
    public void SetPlayer(GameObject player)
    {
        this.player = player;
    }
}
