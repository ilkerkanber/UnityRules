using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public void NormalMethod()
    {
        Debug.Log(ClassStatic.GetMessage());
    }
}
