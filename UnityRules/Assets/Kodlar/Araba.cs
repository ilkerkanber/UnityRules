using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Araba 
{
    
    public string Adı { get; set; }
    public int Modeli { get; set; }
    public int Km { get; set; }

    public int Fiyat { get; protected set; }
    //Protected oluşturduğu miraslı classta erişebilir

    public virtual void Satış() {

        Fiyat = 5000;
    }
}
