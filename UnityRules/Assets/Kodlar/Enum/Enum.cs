using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour

{   public GameObject playerPrefab;
    public string CharacterName;
    public Durumlar durumlar;
   public enum Durumlar
    {
        Basladý,
        DevamEdiyor,
        Bitti
    }
    void Update()
    {
        switch (durumlar)
        {
            case Durumlar.Basladý:
                print("Oyun Baþladý");
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
