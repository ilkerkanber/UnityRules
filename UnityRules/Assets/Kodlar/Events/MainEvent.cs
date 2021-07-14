using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MainEvent : MonoBehaviour
{
    Events events;
    public UnityEvent eventClicked;
    private void Awake()
    {
        events = FindObjectOfType<Events>();
    }
    private void OnEnable()
    {   
        eventClicked.Invoke(); //UnityEvent Olayı
      //  events.ornekDelegateEvent += HandleOrnekEvent1;   
    }
    private void OnDisable()
    {
        events.ornekDelegateEvent -= HandleOrnekEvent1;
    }

    public void HandleOrnekEvent1()
    {
        Debug.Log("Event Başladı");
    }
}
