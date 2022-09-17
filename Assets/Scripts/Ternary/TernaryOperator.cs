using UnityEngine;

public class TernaryOperator : MonoBehaviour
{
    void Start()
    {
        int health = 10;
        string message;

        message = health > 0 ? "Player is Alive" : "Player is Dead";
    }
}