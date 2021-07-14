﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ClassStatic 
{
    public static int ID { get; set; }
    public static string Name { get; set; }
    public static decimal Price { get; set; }

    public static string GetMessage()
    {
        return $"ID:{ID} Name:{Name} Price:{Price}";
    }
}
