using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    // public delegate void OrnekDelegate();
    // public event OrnekDelegate ornekDelegateEvent;
    public event System.Action ornekDelegateEvent; //Geri Değer Döndürmeyen
    public event System.Func<int,int> ornekDelegateEvent2; //Geri Değer Döndüren 
    
    private void OnEnable()
    {
        ornekDelegateEvent?.Invoke();
    }
}
