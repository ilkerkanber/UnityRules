using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainProcess : MonoBehaviour
{

    #region Encapsulation
    void Encapsulation()
    {
        //Insan classındaki private fieldleri public get ile çağırmayı set ile değer vermeyi sağlıyoruz
        Insan I = new Insan();
        I.FirstName = "İlker";
        I.LastName = "Kanber";
        I.Age = 24;
    }
    #endregion



    #region Inheritance
    void Inheritance()
    {
        //Hayvan İnsandan kalıtımları aldı ve insan gibi ad soyad yaşa sahip oldu
        Hayvan H = new Hayvan
        {
            Age = 1,
            FirstName = "İnek",
            LastName = "4Bacak"
        };
    }
    #endregion

    #region Polymorphism
    void Polymorphism()
    {
        Araba ar = new Araba();
        BMW bmw = new BMW();
        //virtual override gibi konular parçası.
    }
    #endregion

    #region Class/StaticClass
    void Class()
    {
        Class cl = new Class
        {
            ID = 1,
            Name="Ali",
            Price=4000
        };

        Class c2 = new Class
        {
            ID = 2,
            Name = "Erman",
            Price = 3000
        };

        //////ÇIKTI
        ///  ID=1 Name=Ali Price=4000
        ///  ID=2 Name=Erman Price=3000
    }

    void StaticClass()
    {
        Class cl = new Class
        {
            ID = 1,
            Name = "Ali",
            Price = 4000
        };

        Class c2 = new Class
        {
            ID = 2,
            Name = "Erman",
            Price = 3000
        };
        //////ÇIKTI Static Tekildir.
       ///  ID=2 Name=Erman Price=3000
    }
    #endregion
}
