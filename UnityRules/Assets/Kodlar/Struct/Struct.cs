using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Struct : MonoBehaviour
{   //STRUCT
    //value
    //Stackte olur.
    //16 byte ve altýndakilerde kullanýlýr.
    //Verilerimiz net ve sabit ise kullanýlmalý.Deðer atayamayýz baþta.
    //Constructor yok.New leyemeyiz.

    //CLASS
    //ref
    //Heapte olur.
    //

    [System.Serializable]
    public struct Book
    {
        public string Name;
        public int Price;
        public int Count;
    }

    public Book book;
    void Start()
    {
        book.Name = "Readable Hearts";
        book.Count = 2;
        book.Price = 250;
    }
}


