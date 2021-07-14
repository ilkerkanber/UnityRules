using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMW : Araba
{   //public sealed class BMW  // sealed miras verdirtmez. // abstr
    //Constructor ctor-tab-tab
    public BMW()
    {

    }
    public BMW(string ArabaAdı)
    {
        Adı = ArabaAdı;
    }

    public BMW(string BMWAd,int BMWModel)
    {
        Adı = BMWAd;
        Modeli = BMWModel;
    }
    public BMW(string BMWAd, int BMWModel, int BMWKm)
    {
        Adı = BMWAd;
        Modeli = BMWModel;
        Km = BMWKm;
    }

    public bool UcuyorMu { get; set; }
    public override void Satış()
    {
        Fiyat = 1000;
    }
}
