using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private void Start()
    {
    }

    private void LateUpdate()
    {
        var pos = MainSceneGM.player.transform.position;
        pos.z = -10;
        transform.position = pos;
    }
}
