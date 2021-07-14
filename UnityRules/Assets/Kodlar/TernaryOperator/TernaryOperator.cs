using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOperator : MonoBehaviour
{
    void Start()
    {
        int health = 10;
        string message;

        message = health > 0 ? "Player Canlý" : "Player Ölü";
        Debug.Log(message);
    }
}
