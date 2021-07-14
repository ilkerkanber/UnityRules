using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    public event System.Action OnControlInvoke;
    // Update is called once per frame
    void OnEnable()
    {
        OnControlInvoke += ControlText;    
    }
    void OnDisable()
    {
        OnControlInvoke -= ControlText;    
    }
    void Start()
    {
        InvokeRepeating("InvokeText", 2, 4);
    }
    void Update()
    {   
       // OnControlInvoke?.Invoke();
       // CancelInvoke("ControlText");
    }
    void ControlText()
    {
        Debug.Log("Event Invoke gerçekleþti");
    }
    void InvokeText()
    {
        Debug.Log("Invoke gerçekleþti");
    }
}
