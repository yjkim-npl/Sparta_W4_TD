using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject player;


    private void LateUpdate()
    {
        var pos = player.transform.position;
        pos.z = -10;
        transform.position = pos;
    }
}
