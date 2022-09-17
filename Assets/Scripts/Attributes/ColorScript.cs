using UnityEngine;

[ExecuteInEditMode]
public class ColorScript : MonoBehaviour
{
    void Start()
    {
        foreach (var rend in GetComponentsInChildren<Renderer>(true))
        {
            rend.sharedMaterial.color = Color.red;
        }
    }
}