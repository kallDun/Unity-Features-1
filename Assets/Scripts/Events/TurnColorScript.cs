using UnityEngine;

public class TurnColorScript : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.OnClicked += TurnColor;
    }

    void OnDisable()
    {
        EventManager.OnClicked -= TurnColor;
    }

    void TurnColor()
    {
        Color col = new(Random.value, Random.value, Random.value);
        foreach (var rend in GetComponentsInChildren<Renderer>(true))
        {
            rend.sharedMaterial.color = col;
        }
    }
}