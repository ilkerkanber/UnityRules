using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour

{   public GameObject playerPrefab;
    public string CharacterName;
    public Durumlar durumlar;
   public enum Durumlar
    {
        Baslad�,
        DevamEdiyor,
        Bitti
    }
    void Update()
    {
        switch (durumlar)
        {
            case Durumlar.Baslad�:
                print("Oyun Ba�lad�");
                break;

            case Durumlar.DevamEdiyor:
                print("Oyun DevamEdiyor");
                break;

            case Durumlar.Bitti:
                print("Oyun Bitti");
                break;
        }
    }


}
