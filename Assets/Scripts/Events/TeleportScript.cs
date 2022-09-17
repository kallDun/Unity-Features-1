using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.OnClicked += Teleport;
    }
    void OnDisable()
    {
        EventManager.OnClicked -= Teleport;
    }
    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(0.01f, 0.03f);
        transform.position = pos;
    }
}